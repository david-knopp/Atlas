using UnityEditor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Atlas
{
    /// <summary>
    /// Helper class for adding/removing scripting define symbols 
    /// </summary>
    public static class ScriptingDefines
    {
        /// <summary>
        /// Determines if the given target group has the given symbol defined
        /// </summary>
        /// <param name="group">Build group to check</param>
        /// <param name="symbol">Preprocessor symbol to check for<</param>
        /// <returns>true if the symbol is define, false if not</returns>
        public static bool ContainsSymbol( BuildTargetGroup group, string symbol )
        {
            string defineSymbolsStr = PlayerSettings.GetScriptingDefineSymbolsForGroup( group );
            List<string> defineSymbols = defineSymbolsStr.Split( ';' ).Select( x => x.Trim() ).ToList();

            return defineSymbols.Contains( symbol );
        }

        /// <summary>
        /// Determines if the current build group has the given symbol defined
        /// </summary>
        /// <param name="symbol">Preprocessor symbol to check for<</param>
        /// <returns>true if the symbol is define, false if not</returns>
        public static bool ContainsSymbol( string symbol )
        {
            return ContainsSymbol( EditorUserBuildSettings.selectedBuildTargetGroup, symbol );
        }

        /// <summary>
        /// Adds the given preprocessor definition to the PlayerSettings for the given build group
        /// </summary>
        /// <param name="group">Build group to add the symbol to</param>
        /// <param name="symbol">Preprocessor symbol to add</param>
        public static void AddSymbol( BuildTargetGroup group, string symbol )
        {
            string defineSymbolsStr = PlayerSettings.GetScriptingDefineSymbolsForGroup( group );
            List<string> defineSymbols = defineSymbolsStr.Split( ';' ).Select( x => x.Trim() ).ToList();

            if ( !defineSymbols.Contains( symbol ) )
            {
                defineSymbols.Add( symbol );
                PlayerSettings.SetScriptingDefineSymbolsForGroup( group, string.Join( ";", defineSymbols.ToArray() ) );
            }
        }

        /// <summary>
        /// Adds the given preprocessor definition to the PlayerSettings for all valid build groups
        /// </summary>
        /// <param name="symbol">Preprocessor symbol to add</param>
        public static void AddSymbol( string symbol )
        {
            foreach ( BuildTargetGroup group in Enum.GetValues( typeof( BuildTargetGroup ) ) )
            {
                if ( IsGroupValid( group ) )
                {
                    AddSymbol( group, symbol );
                }
            }
        }

        /// <summary>
        /// Removes the given preprocessor definition from the PlayerSettings for the given build groups
        /// </summary>
        /// <param name="group">Build group to remove the symbol from</param>
        /// <param name="symbol">Preprocessor symbol to add</param>
        public static void RemoveSymbol( BuildTargetGroup group, string symbol )
        {
            string defineSymbolsStr = PlayerSettings.GetScriptingDefineSymbolsForGroup( group );
            List<string> defineSymbols = defineSymbolsStr.Split( ';' ).Select( x => x.Trim() ).ToList();

            if ( defineSymbols.Contains( symbol ) )
            {
                defineSymbols.Remove( symbol );
                PlayerSettings.SetScriptingDefineSymbolsForGroup( group, string.Join( ";", defineSymbols.ToArray() ) );
            }
        }

        /// <summary>
        /// Removes the given preprocessor definition from the PlayerSettings for all valid build groups
        /// </summary>
        /// <param name="symbol">Preprocessor symbol to add</param>
        public static void RemoveSymbol( string symbol )
        {
            foreach ( BuildTargetGroup group in Enum.GetValues( typeof( BuildTargetGroup ) ) )
            {
                if ( IsGroupValid( group ) )
                {
                    RemoveSymbol( group, symbol );
                }
            }
        }

        /// <summary>
        /// Checks if the given group is valid
        /// </summary>
        /// <param name="group">The group to check</param>
        /// <returns>true if valid, false if invalid</returns>
        public static bool IsGroupValid( BuildTargetGroup group )
        {
            if ( group != BuildTargetGroup.Unknown &&
                 group.IsObsolete() == false )
            {
                return true;
            }

            return false;
        }
    }
}