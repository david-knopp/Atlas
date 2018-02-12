using UnityEngine;
using UnityEditor;
using UnityEditorInternal;
using System.Text;

namespace Atlas
{
    public class LayerFileGenerator
    {
        [MenuItem( "Atlas/Generate Layer File" )]
        public static void Generate()
        {
            string[] layerNames = InternalEditorUtility.layers;

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append( "// This file was generated using Atlas, to re-generate use 'Atlas/Generate Layer File' from the Unity Editor toolbar\n\n" );
            stringBuilder.Append( "public static class Layer\n" );
            stringBuilder.Append( "{\n" );
            stringBuilder.Append( "" );

            // indexes
            foreach ( string name in layerNames )
            {

            }

            // masks


            stringBuilder.Append( "}" );
        }
    }

    public static class Layer
    {

    }
}