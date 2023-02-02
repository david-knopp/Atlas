using System.Text;
using UnityEngine;

namespace Atlas
{
    public static class StringUtility
    {
        public const string EnglishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        public static string GetRandomString( int length, string possibleCharacters = EnglishAlphabet )
        {
            if ( string.IsNullOrEmpty( possibleCharacters ) )
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();

            for ( int i = 0; i < length; i++ )
            {
                int randCharacterIndex = Random.Range( 0, possibleCharacters.Length );
                sb.Append( possibleCharacters[randCharacterIndex] );
            }

            return sb.ToString();
        }
    }
}
