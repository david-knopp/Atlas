using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_GUIColorScope : MonoBehaviour
    {
        private void OnGUI()
        {
            GUILayout.Label( "Atlas rules (default color)" );

            using ( new GUIColorScope( Color.red ) )
            {
                GUILayout.Label( "Atlas rules (red)" );
            }

            GUILayout.Label( "Atlas rules (default color)" );
        }
    }
}