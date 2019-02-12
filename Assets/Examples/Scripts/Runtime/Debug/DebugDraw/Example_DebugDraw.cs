using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_DebugDraw : MonoBehaviour
    {
        private void Update()
        {
            // Draws a billboarded string of text for 1 frame
            DebugDraw.DrawText( Vector3.zero, 
                                "Hi, how are ya?", 
                                Color.cyan, 
                                2f, 
                                AnchorPosition.Center );
        }

        private void OnDisable()
        {
            // Draws a billboarded string of text for 3 seconds
            DebugDraw.DrawText( Vector3.zero, 
                                "Later, gator", 
                                Color.red, 
                                1f, 
                                3f, 
                                AnchorPosition.TopRight );
        }
    }
}