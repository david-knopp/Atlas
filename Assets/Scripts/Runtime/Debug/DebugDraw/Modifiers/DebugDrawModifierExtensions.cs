using UnityEngine;

namespace Atlas
{
    public static class DebugDrawModifierExtensions
    {
        public static IDebugDrawer Timed( this IDebugDrawer drawer, float lifetime )
        {
            return new TimedDebugDrawModifier( drawer, lifetime );
        }

        public static IDebugDrawer Transformed( this IDebugDrawer drawer, Vector3 position )
        {
            return new TransformDebugDrawModifier( drawer, position );
        }

        public static IDebugDrawer Transformed( this IDebugDrawer drawer, Vector3 position, Quaternion rotation )
        {
            return new TransformDebugDrawModifier( drawer, position, rotation );
        }

        public static IDebugDrawer Billboarded( this IDebugDrawer drawer, Vector3 position )
        {
            return new BillboardDebugDrawModifier( drawer, position );
        }

        public static IDebugDrawer Billboarded( this IDebugDrawer drawer, Vector3 position, Camera camera )
        {
            return new BillboardDebugDrawModifier( drawer, position, camera );
        }
    }
}