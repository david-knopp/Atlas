using System.Text;
using UnityEngine;

namespace Atlas
{
    public struct TextIndentHelper
    {
        public static readonly TextIndentHelper StandardTabHelper = new TextIndentHelper( '\t', 1 );
        public static readonly TextIndentHelper StandardSpacesHelper = new TextIndentHelper( ' ', 4 );

        public TextIndentHelper( char indentCharacter = ' ',
                                 int charactersPerIndent = 4 )
        {
            m_indentChar = indentCharacter;
            m_charsPerIndent = charactersPerIndent;
            m_indentLevel = 0;
            Indent = string.Empty;

            RefreshIndent();
        }

        public string Indent
        {
            get;
            private set;
        }

        public int IndentLevel
        {
            get { return m_indentLevel; }

            set
            {
                m_indentLevel = Mathf.Max( 0, value );
                RefreshIndent();
            }
        }

        public int CharactersPerIndent
        {
            get { return m_charsPerIndent; }

            set
            {
                m_charsPerIndent = Mathf.Max( 0, value );
                RefreshIndent();
            }
        }

        public string ApplyIndent( string text )
        {
            return string.Format( "{0}{1}", Indent, text );
        }

        private char m_indentChar;
        private int m_indentLevel;
        private int m_charsPerIndent;

        private void RefreshIndent()
        {
            StringBuilder sb = new StringBuilder();

            int numCharacters = m_indentLevel * m_charsPerIndent;
            for ( int i = 0; i < numCharacters; i++ )
            {
                sb.Append( m_indentChar );
            }

            Indent = sb.ToString();
        }
    }
}