using UnityEngine;
using UnityEditor;
using UnityEditorInternal;
using System.Text;
using System;
using System.IO;

namespace Atlas
{
    public class LayerFileGenerator
    {
        [MenuItem( "Atlas/Generate Layer File" )]
        public static void Generate()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append( "// This file was generated using Atlas, to re-generate use 'Atlas/Generate Layer File' from the Unity Editor toolbar\n\n" );
            stringBuilder.Append( "public static class Layer\n" );
            stringBuilder.Append( "{\n" );

            AppendClass( stringBuilder, "Name", ( string layerName ) => { return string.Format( "\"{0}\"", layerName ); } );
            stringBuilder.Append( "\n" );
            AppendClass( stringBuilder, "Index", LayerMask.NameToLayer );
            stringBuilder.Append( "\n" );
            AppendClass( stringBuilder, "Mask", ( string layerName ) => { return 1 << LayerMask.NameToLayer( layerName ); } );

            stringBuilder.Append( "}" );

            // save file
            string path = string.Format( "{0}{1}", Application.dataPath, "/Scripts/Atlas/Runtime/Utils/Layer.cs" );
            File.WriteAllText( path, stringBuilder.ToString() );
            AssetDatabase.ImportAsset( "Assets/Scripts/Atlas/Runtime/Utils/Layer.cs", ImportAssetOptions.ForceUpdate );
        }

        private static void AppendClass<TElement>( StringBuilder stringBuilder, string className, Func<string, TElement> elementValueCallback )
        {
            Type elementType = typeof( TElement );
            string[] layerNames = InternalEditorUtility.layers;

            stringBuilder.Append( string.Format( "     public static class {0}\n", className ) );
            stringBuilder.Append( "     {\n" );

            for ( int i = 0; i < layerNames.Length; i++ )
            {
                string layerName = layerNames[i];
                stringBuilder.Append( string.Format( "          public const {0} {1} = {2};\n", elementType.FullName, layerName.Replace( " ", String.Empty ), elementValueCallback.Invoke( layerName ) ) );
            }

            stringBuilder.Append( "     }\n" );
        }
    }
}