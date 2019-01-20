using UnityEngine;

namespace Atlas
{
    public static class DebugExtensions
    {
        public static void DrawX( Vector3 pos, float lineLength )
        {
            float twoRootTwo = 2.828f;
            float d = lineLength / twoRootTwo;

            Vector3 min = new Vector3( pos.x - d, pos.y - d, 0.0f );
            Vector3 max = new Vector3( pos.x + d, pos.y + d, 0.0f );

            Debug.DrawLine( min, max );
            Debug.DrawLine( new Vector3( min.x, max.y, 0.0f ), new Vector3( max.x, min.y, 0.0f ) );
        }

        public static void DrawX( Vector3 pos, float lineLength, Color color )
        {
            Color prevColor = GUI.color;
            GUI.color = color;

            DrawX( pos, lineLength );

            GUI.color = prevColor;
        }
    }
}