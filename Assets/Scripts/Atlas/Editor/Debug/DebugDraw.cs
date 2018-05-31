using UnityEditor;

namespace Atlas
{
    [InitializeOnLoad]
    public class DebugDrawEditor
    {
        static DebugDrawEditor()
        {
            bool runtimeEnabled = EditorPrefs.GetBool( c_runtimePrefsKey, false );
            SetRuntimeEnabled( runtimeEnabled );

            s_compileTimeEnabled = EditorPrefs.GetBool( c_compileTimePrefsKey, false );
            SetCompileTimeEnabled( s_compileTimeEnabled );
        }

        private const string c_runtimePrefsKey = "IsDebugDrawEnabled_Runtime";
        private const string c_compileTimePrefsKey = "IsDebugDrawEnabled_CompileTIme";
        private const string c_runtimeMenuPath = "Atlas/Debug/Enable Debug Draw (Runtime)";
        private const string c_compileTimeMenuPath = "Atlas/Debug/Enable Debug Draw (Compile-time)";
        private const string c_defineSymbol = "ATLAS_DEBUG_DRAW";

        private static bool s_compileTimeEnabled;

        [MenuItem( c_runtimeMenuPath )]
        private static void ToggleRuntimeEnabled()
        {
            SetRuntimeEnabled( !DebugDraw.IsEnabled );
        }

        [MenuItem( c_compileTimeMenuPath )]
        private static void ToggleCompileTimeEnabled()
        {
            SetCompileTimeEnabled( !s_compileTimeEnabled );
        }

        private static void SetRuntimeEnabled( bool isEnabled )
        {
            EditorPrefs.SetBool( c_runtimePrefsKey, isEnabled );
            Menu.SetChecked( c_runtimeMenuPath, isEnabled );
            DebugDraw.IsEnabled = isEnabled;
        }

        private static void SetCompileTimeEnabled( bool isEnabled )
        {
            s_compileTimeEnabled = isEnabled;
            EditorPrefs.SetBool( c_compileTimePrefsKey, isEnabled );
            Menu.SetChecked( c_compileTimeMenuPath, isEnabled );

            if ( isEnabled )
            {
                ScriptingDefines.AddSymbol( c_defineSymbol );
            }
            else
            {
                ScriptingDefines.RemoveSymbol( c_defineSymbol );
            }
        }
    }
}
