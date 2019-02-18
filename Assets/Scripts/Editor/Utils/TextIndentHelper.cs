using System.Text;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// A helper object for making text indentation management easier, particularly when working
    /// with code generation
    /// </summary>
    public struct TextIndentHelper
    {
        #region public
        /// <summary>
        /// Default helper for providing 1 tab per indentation
        /// </summary>
        public static readonly TextIndentHelper StandardTabHelper = new TextIndentHelper( '\t', 1 );

        /// <summary>
        /// Default helper for providing 4 spaces per indentation
        /// </summary>
        public static readonly TextIndentHelper StandardSpacesHelper = new TextIndentHelper( ' ', 4 );

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="indentCharacter">The character to use as indentation, with a space as default</param>
        /// <param name="charactersPerIndent">Number of characters to use per indentation</param>
        public TextIndentHelper( char indentCharacter = ' ',
                                 int charactersPerIndent = 4 )
        {
            m_indentChar = indentCharacter;
            m_charsPerIndent = charactersPerIndent;
            m_indentLevel = 0;
            Indent = string.Empty;

            RefreshIndent();
        }

        /// <summary>
        /// A string representing the current indentation level. 
        /// This will initially be an empty string.
        /// </summary>
        public string Indent
        {
            get;
            private set;
        }

        /// <summary>
        /// The current level/number of indentations
        /// </summary>
        public int IndentLevel
        {
            get { return m_indentLevel; }

            set
            {
                m_indentLevel = Mathf.Max( 0, value );
                RefreshIndent();
            }
        }

        /// <summary>
        /// Number of characters to use per indentation
        /// </summary>
        public int CharactersPerIndent
        {
            get { return m_charsPerIndent; }

            set
            {
                m_charsPerIndent = Mathf.Max( 0, value );
                RefreshIndent();
            }
        }

        /// <summary>
        /// Helper method for applying the current indentation to the given string.
        /// This is equivalent to prepending <see cref="Indent"/> to the front of <paramref name="text"/>
        /// </summary>
        /// <param name="text">The string to apply indentation to</param>
        /// <returns>The indented string</returns>
        public string ApplyIndent( string text )
        {
            return string.Format( "{0}{1}", Indent, text );
        } 
        #endregion public

        #region private
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
        #endregion private
    }
}