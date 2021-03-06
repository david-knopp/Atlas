﻿using UnityEngine;
using UnityEditor;
using UnityEditorInternal;
using System.Text;
using System;
using System.IO;
using Atlas.Internal;

namespace Atlas
{
    internal static class LayerFileGenerator
    {
        public static string ProjectRelativeLayerFilePath
        {
            get { return string.Format( "{0}/Layer.cs", ScriptingSettings.RuntimePath ); }
        }

        public static string FullLayerFilePath
        {
            get { return string.Format( "{0}/{1}", Application.dataPath, ProjectRelativeLayerFilePath ); ; }
        }

        [MenuItem( "Atlas/Generate Layer File" )]
        public static void Generate()
        {
            // generate code text
            StringBuilder stringBuilder = new StringBuilder();
            TextIndentHelper indent = TextIndentHelper.StandardSpacesHelper;

            stringBuilder.Append( "// This file was generated using Atlas, to re-generate use 'Atlas/Generate Layer File' from the Unity Editor toolbar\n" );
            stringBuilder.Append( "//   To change the destination folder or namespace for this file, use 'Edit/Preferences/Atlas'\n\n" );

            stringBuilder.AppendFormat( "namespace {0}\n", ScriptingSettings.NamespaceName );
            stringBuilder.Append( "{\n" );
            indent.IndentLevel++;

                stringBuilder.Append( indent.ApplyIndent( "public static class Layer\n" ) );
                stringBuilder.Append( indent.ApplyIndent( "{\n" ) );
                indent.IndentLevel++;

                    AppendClass( stringBuilder, "Name", indent, ( string layerName ) => { return string.Format( "\"{0}\"", layerName ); } );
                    stringBuilder.Append( "\n" );
                    AppendClass( stringBuilder, "Index", indent, LayerMask.NameToLayer );
                    stringBuilder.Append( "\n" );
                    AppendClass( stringBuilder, "Mask", indent, ( string layerName ) => { return 1 << LayerMask.NameToLayer( layerName ); } );

                indent.IndentLevel--;
                stringBuilder.Append( indent.ApplyIndent( "}\n" ) );

            indent.IndentLevel--;
            stringBuilder.Append( indent.ApplyIndent( "}" ) );

            string fullPath = FullLayerFilePath;

            // create directory if needed
            if ( Directory.Exists( fullPath ) == false )
            {
                Directory.CreateDirectory( Path.GetDirectoryName( fullPath ) );
            }

            // save to file
            using ( StreamWriter writer = new StreamWriter( fullPath, false ) )
            {
                writer.Write( stringBuilder.ToString() );
            }
            
            AssetDatabase.ImportAsset( string.Format( "Assets/{0}", ProjectRelativeLayerFilePath ), ImportAssetOptions.ForceUpdate );

            Debug.LogFormat( "Generated `Layer.cs` at `{0}`\nTo change the destination folder or namespace for this file, use 'Edit/Preferences/Atlas'", 
                             ScriptingSettings.RuntimePath );
        }

        private static void AppendClass<TElement>( StringBuilder stringBuilder, string className, TextIndentHelper indent, Func<string, TElement> elementValueCallback )
        {
            Type elementType = typeof( TElement );
            string[] layerNames = InternalEditorUtility.layers;

            stringBuilder.AppendFormat( "{0}public static class {1}\n", indent.Indent, className );
            stringBuilder.Append( indent.ApplyIndent( "{\n" ) );
            indent.IndentLevel++;

            for ( int i = 0; i < layerNames.Length; i++ )
            {
                string layerName = layerNames[i];
                stringBuilder.AppendFormat( "{0}public const {1} {2} = {3};\n", indent.Indent, elementType.GetPrimitiveName(), layerName.Replace( " ", string.Empty ), elementValueCallback.Invoke( layerName ) );
            }

            indent.IndentLevel--;
            stringBuilder.Append( indent.ApplyIndent( "}\n" ) );
        }
    }
}