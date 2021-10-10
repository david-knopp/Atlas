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

            AppendSwizzles<Vector2>( "Vector{0}", new Range( 2, 4 ), 'X', 'Y', '_' );
            AppendSwizzles<Vector3>( "Vector{0}", new Range( 2, 4 ), 'X', 'Y', 'Z', '_' );
            AppendSwizzles<Vector4>( "Vector{0}", new Range( 2, 4 ), 'X', 'Y', 'Z', 'W', '_' );
            AppendSwizzles<Vector2Int>( "Vector{0}Int", new Range( 2, 3 ), 'X', 'Y', '_' );
            AppendSwizzles<Vector3Int>( "Vector{0}Int", new Range( 2, 3 ), 'X', 'Y', 'Z', '_' );
            AppendSwizzles<Color>( "Color", 4, 'R', 'G', 'B', 'A', '_' );

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

        private void AppendSwizzles<TInput>( string outputTypeFormat, Range outputComponentRange, params char[] displayValues )
            where TInput : struct
        {
            for ( int i = ( int )outputComponentRange.MinValue; i <= ( int )outputComponentRange.MaxValue; i++ )
            {
                AppendSwizzles<TInput>( string.Format( outputTypeFormat, i ), i, displayValues );
            }
        }

        private void AppendSwizzles<TInput>( string outputTypeName, int outputComponentCount, params char[] displayValues )
            where TInput : struct
        {
            string inputTypeName = typeof( TInput ).Name;

            // put e.g. .XX in regions, this assumes 'x' is the first value in displayValues
            string regionComponents = GetFunctionString( 0, outputComponentCount, displayValues );
            m_stringBuilder.Append( m_indent.ApplyIndent( $"#region {inputTypeName}.{regionComponents}" ) );

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
                m_stringBuilder.Append( m_indent.ApplyIndent( $"public static {outputTypeName} {display}( this {inputTypeName} {c_argName} )\n" ) );
                m_stringBuilder.Append( m_indent.ApplyIndent( "{\n" ) );
                m_indent.IndentLevel++;

                m_stringBuilder.Append( m_indent.ApplyIndent( $"return new {outputTypeName}( {GetReturnString<TInput>( display )} );\n" ) );

                m_indent.IndentLevel--;
                m_stringBuilder.Append( m_indent.ApplyIndent( "}\n" ) );
            }

            m_stringBuilder.Append( m_indent.ApplyIndent( $"#endregion {inputTypeName}.{regionComponents}\n\n" ) );
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

        private static string GetReturnString<TInput>( string displayString )
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

                    case 'R':
                        sb.Append( $"{c_argName}.r" );
                        break;

                    case 'G':
                        sb.Append( $"{c_argName}.g" );
                        break;

                    case 'B':
                        sb.Append( $"{c_argName}.b" );
                        break;

                    case 'A':
                        sb.Append( $"{c_argName}.a" );
                        break;

                    case '_' when typeof( TInput ) == typeof( Vector2Int ):
                    case '_' when typeof( TInput ) == typeof( Vector3Int ):
                        sb.Append( "0" );
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
