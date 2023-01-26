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

        private static float m_previousTimeScale = 1.0f;

        private void OnGUI()
        {
            EditorGUILayout.Space();

            using ( var changeCheck = new EditorGUI.ChangeCheckScope() )
            {
                float timeScale = EditorGUILayout.Slider( "Time Scale", Time.timeScale, 0f, 10f );

                if ( changeCheck.changed )
                {
                    Time.timeScale = timeScale;
                }
            }

            void DrawTimeScaleButton( float timeScale )
            {
                if ( GUILayout.Button( $"{timeScale}x" ) )
                {
                    Time.timeScale = timeScale;
                }
            }

            EditorGUILayoutUtility.HorizontalLine();

            EditorGUILayout.BeginHorizontal();

            // pause/play
            if ( Time.timeScale == 0.0f )
            {
                using ( new GUIBackgroundColorScope( Color.green ) )
                {
                    if ( GUILayout.Button( EditorGUIUtility.IconContent( "d_PlayButton" ) ) )
                    {
                        Time.timeScale = m_previousTimeScale;
                    } 
                }
            }
            else
            {
                using ( new GUIBackgroundColorScope( Color.red ) )
                {
                    if ( GUILayout.Button( EditorGUIUtility.IconContent( "d_PauseButton" ) ) )
                {
                    m_previousTimeScale = Time.timeScale;
                    Time.timeScale = 0.0f;
                    }
                }
            }

            DrawTimeScaleButton( 1.0f );
            DrawTimeScaleButton( 2.0f );
            DrawTimeScaleButton( 4.0f );
            DrawTimeScaleButton( 10.0f );

            EditorGUILayout.EndHorizontal();
        }
    }
}
