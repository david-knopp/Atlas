using System;
using System.Collections.Generic;
using UnityEngine.Assertions;

namespace Atlas
{
    public class TaskScheduler : IScheduledTask
    {
        #region public
        public struct TaskRecord : IEquatable<TaskRecord>
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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="phaseIterationCount">Number of frames to use when determining the optimum phase for a task</param>
        public TaskScheduler( int phaseIterationCount )
        {
            m_tasks = new List<TaskRecord>();
            m_frame = 0;
            m_phaseIterationCount = phaseIterationCount;
        }

        public int TaskCount
        {
            get { return m_tasks.Count; }
        }

        public int Frame
        {
            get { return m_frame; }
        }

        /// <summary>
        /// Registers the given task for scheduled updates
        /// </summary>
        /// <param name="task">The task to schedule</param>
        /// <param name="frequency">The desired update frequency, in frames</param>
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
        /// Registers the given task for scheduled updates, with an automatic phase assignment
        /// </summary>
        /// <param name="task">The task to schedule</param>
        /// <param name="frequency">The desired update frequency, in frames</param>
        public void AddTask( IScheduledTask task, uint frequency )
        {
            Assert.IsFalse( frequency == 0, string.Format( "TaskScheduler.AddTask: Frequency for task '{0}' must be greater than 0", task ) );

            AddTask( task, frequency, FindOptimumPhase() );
        }

        public void RemoveTask( IScheduledTask task )
        {
            int index = m_tasks.FindIndex( x => x.m_task == task );
            Assert.IsTrue( index > 0, string.Format( "TaskScheduler.RemoveTask: Task '{0}' isn't registered with the scheduler", task ) );

            if ( index > 0 )
            {
                m_tasks.RemoveAt( index );
            }
        }

        public void ChangeFrequency( IScheduledTask task, uint frequency )
        {
            Assert.IsFalse( frequency == 0, string.Format( "TaskScheduler.ChangeFrequency: Frequency for task '{0}' must be greater than 0", task ) );

            // remove and re-add task to recalculate phase
            RemoveTask( task );
            AddTask( task, frequency );
        }

        public void ScheduledTick()
        {
            for ( int i = 0; i < m_tasks.Count; i++ )
            {
                TaskRecord record = m_tasks[i];
                if ( IsTaskScheduled( record, m_frame ) )
                {
                    record.m_task.ScheduledTick();
                }
            }
            ++m_frame;
        }
        #endregion // public

        #region private
        private List<TaskRecord> m_tasks;
        private int m_frame;
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
            for ( int frame = m_frame; frame < m_phaseIterationCount; ++frame )
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
                    phase = frame - m_frame;
                }
            }

            return phase;
        }
        #endregion // private
    }
}