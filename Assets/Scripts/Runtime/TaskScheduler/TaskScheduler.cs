using System;
using System.Collections.Generic;
using UnityEngine.Assertions;

namespace Atlas
{
    /// <summary>
    /// Handles scheduling and distributing task execution between frames, attempting to balance frame-by-frame execution
    /// so one frame isn't heavier than the another.
    /// </summary>
    /// <seealso cref="IScheduledTask"/>
    public sealed class TaskScheduler : IScheduledTask
    {
        #region public
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="phaseIterationCount">Number of frames to look ahead at when determining the optimum phase for a task</param>
        public TaskScheduler( int phaseIterationCount = 10 )
        {
            m_tasks = new List<TaskRecord>();
            Frame = 0;
            m_phaseIterationCount = phaseIterationCount;
        }

        /// <summary>
        /// Number of tasks currently scheduled to execute
        /// </summary>
        public int TaskCount
        {
            get { return m_tasks.Count; }
        }

        /// <summary>
        /// This scheduler's current frame count
        /// </summary>
        public int Frame
        {
            get;
            private set;
        }

        /// <summary>
        /// Registers the given task for scheduled updates
        /// </summary>
        /// <param name="task">The task to schedule</param>
        /// <param name="frequency">The desired update frequency (in frames)</param>
        /// <param name="phase">An offset used to scatter tasks with similar frequencies</param>
        public void AddTask( IScheduledTask task, uint frequency, int phase )
        {
            Assert.IsFalse( frequency == 0, string.Format( "TaskScheduler.AddTask: Frequency for task '{0}' must be greater than 0", task ) );

            m_tasks.Add( new TaskRecord
            {
                m_task = task,
                m_frequency = frequency,
                m_phase = phase
            } );
        }

        /// <summary>
        /// Registers the given task for scheduled updates, with an automatic phase assignment.
        /// This method will be a bit slower than <see cref="AddTask(IScheduledTask, uint, int)"/>, as it will evaluate the number of
        /// scheduled tasks for upcoming frames in an attempt to select an optimum phase offset for the given <paramref name="task"/>.
        /// </summary>
        /// <param name="task">The task to schedule</param>
        /// <param name="frequency">The desired update frequency (in frames)</param>
        public void AddTask( IScheduledTask task, uint frequency )
        {
            Assert.IsFalse( frequency == 0, string.Format( "TaskScheduler.AddTask: Frequency for task '{0}' must be greater than 0", task ) );

            AddTask( task, frequency, FindOptimumPhase() );
        }

        /// <summary>
        /// Unregisters the given task
        /// </summary>
        /// <param name="task">The task to remove</param>
        public void RemoveTask( IScheduledTask task )
        {
            int index = m_tasks.FindIndex( x => x.m_task == task );
            Assert.IsTrue( index > 0, string.Format( "TaskScheduler.RemoveTask: Task '{0}' isn't registered with the scheduler", task ) );

            if ( index > 0 )
            {
                m_tasks.RemoveAt( index );
            }
        }

        /// <summary>
        /// Changes the frequency for a task that is already managed by this scheduler
        /// </summary>
        /// <param name="task">The task to update</param>
        /// <param name="frequency">The task's desired frequency</param>
        public void ChangeFrequency( IScheduledTask task, uint frequency )
        {
            Assert.IsFalse( frequency == 0, string.Format( "TaskScheduler.ChangeFrequency: Frequency for task '{0}' must be greater than 0", task ) );

            // remove and re-add task to recalculate phase
            RemoveTask( task );
            AddTask( task, frequency );
        }

        /// <summary>
        /// Updates the scheduler, and any tasks scheduled to execute on the scheduler's current <see cref="Frame"/>
        /// </summary>
        public void ScheduledTick()
        {
            for ( int i = 0; i < m_tasks.Count; i++ )
            {
                TaskRecord record = m_tasks[i];
                if ( IsTaskScheduled( record, Frame ) )
                {
                    record.m_task.ScheduledTick();
                }
            }
            ++Frame;
        }
        #endregion // public

        #region private
        private struct TaskRecord : IEquatable<TaskRecord>
        {
            public IScheduledTask m_task;
            public uint m_frequency;
            public int m_phase;

            // implement IEquatable to avoid allocations for calls to List.Contains
            public bool Equals( TaskRecord record )
            {
                return m_task == record.m_task &&
                       m_frequency == record.m_frequency &&
                       m_phase == record.m_phase;
            }

            public override bool Equals( object obj )
            {
                return Equals( ( TaskRecord )obj );
            }

            public override int GetHashCode()
            {
                return HashCode.Combine( m_task.GetHashCode(),
                                         m_frequency.GetHashCode(),
                                         m_phase.GetHashCode() );
            }
        }

        private List<TaskRecord> m_tasks;
        private int m_phaseIterationCount;

        private bool IsTaskScheduled( TaskRecord record, int frame )
        {
            int offsetFrame = frame - record.m_phase;
            return offsetFrame >= 0 &&
                   ( offsetFrame % record.m_frequency ) == 0;
        }

        private int FindOptimumPhase()
        {
            int phase = 0;
            int minTaskCount = int.MaxValue;

            // look ahead to find frame with fewest running tasks
            for ( int frame = Frame; frame < m_phaseIterationCount; ++frame )
            {
                int frameTaskCount = 0;

                // count number of tasks scheduled to run this frame
                for ( int i = 0; i < m_tasks.Count; i++ )
                {
                    if ( IsTaskScheduled( m_tasks[i], frame ) )
                    {
                        ++frameTaskCount;
                    }
                }

                if ( frameTaskCount < minTaskCount )
                {
                    minTaskCount = frameTaskCount;
                    phase = frame - Frame;
                }
            }

            return phase;
        }
        #endregion // private
    }
}