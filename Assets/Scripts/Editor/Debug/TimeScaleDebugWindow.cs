using UnityEditor;
using UnityEngine;

namespace Atlas
{
    public sealed class TimeScaleDebugWindow : EditorWindow
    {
        [MenuItem( "Atlas/Debug/Time Scale Debug Window" )]
        private static void Init()
        {
            var window = GetWindow<TimeScaleDebugWindow>( "Time Scale" );
            window.Show();
        }

        private void OnGUI()
        {
            using ( var changeCheck = new EditorGUI.ChangeCheckScope() )
            {
                float timeScale = EditorGUILayout.Slider( "Time Scale", Time.timeScale, 0f, 10f );

                if ( changeCheck.changed )
                {
                    Time.timeScale = timeScale;
                }
            }

            if ( GUILayout.Button( "Reset" ) )
            {
                Time.timeScale = 1.0f;
            }

            if ( GUILayout.Button( "Pause" ) )
            {
                Time.timeScale = 0.0f;
            }
        }
    }
}
