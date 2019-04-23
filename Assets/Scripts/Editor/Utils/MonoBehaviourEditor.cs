using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;
using System.Linq;

namespace Atlas
{
    [CustomEditor( typeof( MonoBehaviour ), true )]
    public class MonoBehaviourEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            DrawAttributeButtons();
        }

        public void DrawAttributeButtons()
        {
            Type type = target.GetType();
            while ( type != typeof( object ) )
            {
                var methods = type.GetMethods( BindingFlags.Public |
                                               BindingFlags.NonPublic |
                                               BindingFlags.Instance |
                                               BindingFlags.DeclaredOnly );

                foreach ( var method in methods )
                {
                    var buttonAttributes = method.GetCustomAttributes( typeof( InspectorButtonAttribute ), false );
                    if ( buttonAttributes.Any() )
                    {
                        if ( GUILayout.Button( method.Name ) )
                        {
                            method.Invoke( target, null );
                        }
                    }
                }

                type = type.BaseType;
            }
        }
    }
}
