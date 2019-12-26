using System.IO;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Atlas.Internal
{
    internal class SwizzleGenerator
    {
        private static string ProjectRelativeDestinationPath => "Scripts/Runtime/Math/Vector/Swizzle.cs";

        private static string FullDestinationPath
        {
            get { return string.Format( "{0}/{1}", Application.dataPath, ProjectRelativeDestinationPath ); ; }
        }

        private const string c_argName = "v";

        private StringBuilder m_stringBuilder = new StringBuilder();
        private TextIndentHelper m_indent = TextIndentHelper.StandardSpacesHelper;

        [MenuItem( "Atlas/Generate Swizzle File" )]
        private static void GenerateSwizzleFile()
        {
            SwizzleGenerator generator = new SwizzleGenerator();
            generator.Generate();
        }

        private void Generate()
        {
            m_stringBuilder.AppendFormat( "using UnityEngine;\n\n" );

            m_stringBuilder.AppendFormat( "namespace Atlas\n" );
            m_stringBuilder.Append( "{\n" );
            m_indent.IndentLevel++;

                m_stringBuilder.Append( m_indent.ApplyIndent( "public static class Swizzle\n" ) );
                m_stringBuilder.Append( m_indent.ApplyIndent( "{\n" ) );
                m_indent.IndentLevel++;

                AppendXXXSwizzles( "Vector3", "X", "Y", "Z", "_" );
                m_stringBuilder.Append( "\n" );

                AppendXXXSwizzles( "Vector2", "X", "Y", "_" );
                m_stringBuilder.Append( "\n" );

                AppendXXSwizzles( "Vector3", "X", "Y", "Z", "_" );
                m_stringBuilder.Append( "\n" );

                AppendXXSwizzles( "Vector2", "X", "Y", "_" );

                m_indent.IndentLevel--;
                m_stringBuilder.Append( m_indent.ApplyIndent( "}\n" ) );

            m_indent.IndentLevel--;
            m_stringBuilder.Append( m_indent.ApplyIndent( "}" ) );

            using ( StreamWriter writer = new StreamWriter( FullDestinationPath, false ) )
            {
                writer.Write( m_stringBuilder.ToString() );
            }

            AssetDatabase.ImportAsset( string.Format( "Assets/{0}", ProjectRelativeDestinationPath ), ImportAssetOptions.ForceUpdate );

            Debug.LogFormat( $"Generated `Swizzle.cs` at `{ProjectRelativeDestinationPath}`" );
        }

        private void AppendXXXSwizzles( string inputType, params string[] displayValues )
        {
            m_stringBuilder.Append( m_indent.ApplyIndent( $"#region {inputType}.XXX" ) );

            int numValues = displayValues.Length;

            for ( int i = 0; i < numValues; i++ )
            {
                for ( int j = 0; j < numValues; j++ )
                {
                    for ( int k = 0; k < numValues; k++ )
                    {
                        if ( displayValues[i] == "_" &&
                             displayValues[j] == "_" &&
                             displayValues[k] == "_" )
                        {
                            continue;
                        }

                        m_stringBuilder.Append( "\n" );
                        m_stringBuilder.Append( m_indent.ApplyIndent( 
                                $"public static Vector3 {displayValues[i]}{displayValues[j]}{displayValues[k]}( this {inputType} {c_argName} )\n" ) );
                        m_stringBuilder.Append( m_indent.ApplyIndent( "{\n" ) );
                        m_indent.IndentLevel++;

                        m_stringBuilder.Append( m_indent.ApplyIndent(
                                $"return new Vector3( {GetValueString( displayValues[i] )}, {GetValueString( displayValues[j] )}, {GetValueString( displayValues[k] )} );\n" ) );

                        m_indent.IndentLevel--;
                        m_stringBuilder.Append( m_indent.ApplyIndent( "}\n" ) );
                    }
                }
            }

            m_stringBuilder.Append( m_indent.ApplyIndent( $"#endregion {inputType}.XXX\n" ) );
        }

        private void AppendXXSwizzles( string inputType, params string[] displayValues )
        {
            m_stringBuilder.Append( m_indent.ApplyIndent( $"#region {inputType}.XX" ) );

            int numValues = displayValues.Length;

            for ( int i = 0; i < numValues; i++ )
            {
                for ( int j = 0; j < numValues; j++ )
                {
                    if ( displayValues[i] == "_" && 
                         displayValues[j] == "_" )
                    {
                        continue;
                    }

                    m_stringBuilder.Append( "\n" );
                    m_stringBuilder.Append( m_indent.ApplyIndent(
                        $"public static Vector2 {displayValues[i]}{displayValues[j]}( this {inputType} {c_argName} )\n" ) );
                    m_stringBuilder.Append( m_indent.ApplyIndent( "{\n" ) );
                    m_indent.IndentLevel++;

                    m_stringBuilder.Append( m_indent.ApplyIndent(
                            $"return new Vector2( {GetValueString( displayValues[i] )}, {GetValueString( displayValues[j] )} );\n" ) );

                    m_indent.IndentLevel--;
                    m_stringBuilder.Append( m_indent.ApplyIndent( "}\n" ) );
                }
            }

            m_stringBuilder.Append( m_indent.ApplyIndent( $"#endregion {inputType}.XX\n" ) );
        }

        private string GetValueString( string valueString )
        {
            switch ( valueString )
            {
                case "X":
                    return $"{c_argName}.x";

                case "Y":
                    return $"{c_argName}.y";

                case "Z":
                    return $"{c_argName}.z";

                case "_":
                    return "0f";

                default:
                    return valueString;
            }
        }
    }
}
