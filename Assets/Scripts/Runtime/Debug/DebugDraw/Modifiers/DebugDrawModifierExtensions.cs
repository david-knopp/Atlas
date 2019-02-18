using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Helpful extension methods to make working with <see cref="IDebugDrawer"/> more user-friendly
    /// </summary>
    public static class DebugDrawModifierExtensions
    {
        /// <summary>
        /// Extension method to modify the given <see cref="IDebugDrawer"/> by adding a draw lifetime
        /// </summary>
        /// <param name="drawer">The drawer to modify</param>
        /// <param name="lifetime">Amount of time (in seconds) to draw the element for</param>
        /// <returns>The original <see cref="IDebugDrawer"/>, wrapped in a <see cref="TimedDebugDrawModifier"/></returns>
        public static IDebugDrawer Timed( this IDebugDrawer drawer, float lifetime )
        {
            return new TimedDebugDrawModifier( drawer, lifetime );
        }

        /// <summary>
        /// Extension method to apply a transformation to a <see cref="IDebugDrawer"/>
        /// </summary>
        /// <param name="drawer">The drawer to transform</param>
        /// <param name="position">The position to apply to the element</param>
        /// <returns>The transformed drawer</returns>
        public static IDebugDrawer Transformed( this IDebugDrawer drawer, Vector3 position )
        {
            return new TransformDebugDrawModifier( drawer, position );
        }

        /// <summary>
        /// Extension method to apply a transformation to a <see cref="IDebugDrawer"/>
        /// </summary>
        /// <param name="drawer">The drawer to transform</param>
        /// <param name="position">The position to apply to the element</param>
        /// <param name="rotation">The rotation to apply to the element</param>
        /// <returns>The transformed drawer</returns>
        public static IDebugDrawer Transformed( this IDebugDrawer drawer, Vector3 position, Quaternion rotation )
        {
            return new TransformDebugDrawModifier( drawer, position, rotation );
        }

        /// <summary>
        /// Extension method to apply a billboarded transformation to the given <see cref="IDebugDrawer"/>.
        /// Uses <see cref="Camera.main"/> by default for billboarding
        /// </summary>
        /// <param name="drawer">The drawer to billboard</param>
        /// <param name="position">The position to aply to the element</param>
        /// <returns>The billboarded drawer</returns>
        public static IDebugDrawer Billboarded( this IDebugDrawer drawer, Vector3 position )
        {
            return new BillboardDebugDrawModifier( drawer, position );
        }

        /// <summary>
        /// Extension method to apply a billboarded transformation to the given <see cref="IDebugDrawer"/>
        /// </summary>
        /// <param name="drawer">The drawer to billboard</param>
        /// <param name="position">The position to aply to the element</param>
        /// <param name="camera">The camera to face the element toward</param>
        /// <returns>The billboarded drawer</returns>
        public static IDebugDrawer Billboarded( this IDebugDrawer drawer, Vector3 position, Camera camera )
        {
            return new BillboardDebugDrawModifier( drawer, position, camera );
        }
    }
}
