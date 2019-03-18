using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Interface for debug draw elements
    /// </summary>
    /// <seealso cref="DebugDraw"/>
    public interface IDebugDrawer
    {
        /// <summary>
        /// Whether or not this drawer has finished drawing yet,
        /// this can be used to allow certain elements to be drawn across
        /// multiple frames
        /// </summary>
        bool IsFinished
        {
            get;
        }

        /// <summary>
        /// The color of the element
        /// </summary>
        Color Color
        {
            get;
            set;
        }

        /// <summary>
        /// Draws the element
        /// </summary>
        void Draw();
    }
}
