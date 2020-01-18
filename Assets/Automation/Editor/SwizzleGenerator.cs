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
            m_stringBuilder.Append( "using UnityEngine;\n\n" );

            m_stringBuilder.Append( "namespace Atlas\n" );
            m_stringBuilder.Append( "{\n" );
            m_indent.IndentLevel++;

            m_stringBuilder.Append( m_indent.ApplyIndent( "public static class Swizzle\n" ) );
            m_stringBuilder.Append( m_indent.ApplyIndent( "{\n" ) );
            m_indent.IndentLevel++;

            for ( int i = 2; i <= 4; i++ )
            {
                AppendSwizzles( 2, i, 'X', 'Y', '_' );
            }

            for ( int i = 2; i <= 4; i++ )
            {
                AppendSwizzles( 3, i, 'X', 'Y', 'Z', '_' );
            }

            for ( int i = 2; i <= 4; i++ )
            {
                AppendSwizzles( 4, i, 'X', 'Y', 'Z', 'W', '_' );
            }

            m_indent.IndentLevel--;
            m_stringBuilder.Append( m_indent.ApplyIndent( "}\n" ) );

            m_indent.IndentLevel--;
            m_stringBuilder.Append( m_indent.ApplyIndent( "}\n" ) );

            using ( StreamWriter writer = new StreamWriter( FullDestinationPath, false ) )
            {
                writer.Write( m_stringBuilder.ToString() );
            }

            AssetDatabase.ImportAsset( string.Format( "Assets/{0}", ProjectRelativeDestinationPath ), ImportAssetOptions.ForceUpdate );

            Debug.LogFormat( $"Generated `Swizzle.cs` at `{ProjectRelativeDestinationPath}`" );
        }

        private void AppendSwizzles( int inputComponentCount, int outputComponentCount, params char[] displayValues )
        {
            // put e.g. .XX in regions, this assumes 'x' is the first value in displayValues
            string regionComponents = GetFunctionString( 0, outputComponentCount, displayValues );
            m_stringBuilder.Append( m_indent.ApplyIndent( $"#region Vector{inputComponentCount}.{regionComponents}" ) );

            int loopCount = 1;
            for ( int i = 0; i < outputComponentCount; i++ )
            {
                loopCount *= displayValues.Length;
            }

            for ( int i = 0; i < loopCount; i++ )
            {
                string display = GetFunctionString( i, outputComponentCount, displayValues );
                if ( IsDisplayValid( display ) == false )
                {
                    continue;
                }

                m_stringBuilder.Append( "\n" );
                m_stringBuilder.Append( m_indent.ApplyIndent( $"public static Vector{outputComponentCount} {display}( this Vector{inputComponentCount} {c_argName} )\n" ) );
                m_stringBuilder.Append( m_indent.ApplyIndent( "{\n" ) );
                m_indent.IndentLevel++;

                m_stringBuilder.Append( m_indent.ApplyIndent( $"return new Vector{outputComponentCount}( {GetReturnString( display )} );\n" ) );

                m_indent.IndentLevel--;
                m_stringBuilder.Append( m_indent.ApplyIndent( "}\n" ) );
            }

            m_stringBuilder.Append( m_indent.ApplyIndent( $"#endregion Vector{inputComponentCount}.{regionComponents}\n\n" ) );
        }

        private static string GetFunctionString( int index, int outputComponentCount, char[] displayValues )
        {
            int displayCount = displayValues.Length;
            char[] result = new char[outputComponentCount];

            for ( int i = outputComponentCount - 1; i >= 0; i-- )
            {
                int componentIndex = index % displayCount;
                result[i] = displayValues[componentIndex];
                index /= displayCount;
            }

            return new string( result );
        }

        private static string GetReturnString( string displayString )
        {
            StringBuilder sb = new StringBuilder();

            for ( int i = 0; i < displayString.Length; i++ )
            {
                char character = displayString[i];

                switch ( character )
                {
                    case 'X':
                        sb.Append( $"{c_argName}.x" );
                        break;

                    case 'Y':
                        sb.Append( $"{c_argName}.y" );
                        break;

                    case 'Z':
                        sb.Append( $"{c_argName}.z" );
                        break;

                    case 'W':
                        sb.Append( $"{c_argName}.w" );
                        break;

                    case '_':
                        sb.Append( "0f" );
                        break;
                }

                if ( i + 1 < displayString.Length )
                {
                    sb.Append( ", " );
                }
            }

            return sb.ToString();
        }

        private static bool IsDisplayValid( string displayString )
        {
            foreach ( char character in displayString )
            {
                if ( character != '_' )
                {
                    return true;
                }
            }

            return false;
        }
    }
}
