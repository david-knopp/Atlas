using UnityEngine;

namespace Atlas
{
    public static class GizmoUtils
    {
        public static void DrawCircle( Vector3 pos, float radius, Vector3 axis, int numSegments = 20 )
        {
            Quaternion rot = Quaternion.FromToRotation( Vector3.up, axis.normalized );
            Vector3 startPos = pos + rot * new Vector3( radius, 0.0f, 0.0f );
            Vector3 prevPos = startPos;

            float twoPi = 2.0f * Mathf.PI;
            float angleDelta = twoPi / numSegments;

            for ( float angle = 0.0f; angle <= twoPi; angle += angleDelta )
            {
                Vector3 curPos = pos + rot * new Vector3( radius * Mathf.Cos( angle ), 
                                                          0.0f, 
                                                          radius * Mathf.Sin( angle ) );
                Gizmos.DrawLine( prevPos, curPos );
                prevPos = curPos;
            }

            Gizmos.DrawLine( prevPos, startPos );
        }
    }
}
