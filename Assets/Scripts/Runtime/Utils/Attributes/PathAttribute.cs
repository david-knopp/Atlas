using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Marks a target string field as a folder path, and automatically provides a button 
    /// next to the field in the inspector window that opens your system's folder browser
    /// </summary>
    /// <seealso cref="ScenePathAttribute"/>
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public sealed class PathAttribute : PropertyAttribute
    {
        /// <summary>
        /// Folder path relativity type
        /// </summary>
        public enum Relativity
        {
            /// <summary>
            /// The full path e.g. "C:/Users/MichaelScott/Documents/"
            /// </summary>
            Absolute = 0,

            /// <summary>
            /// Uses a path that is relative to the project's Assets folder e.g. "Scripts/Runtime/"
            /// </summary>
            AssetsRelative = 1,

            /// <summary>
            /// Uses a path that is relative to the project's root folder e.g. "Assets/Scripts/Runtime/"
            /// </summary>
            ProjectRelative = 2
        }

        /// <summary>
        /// Type of path target to represent
        /// </summary>
        public enum Path
        {
            /// <summary>
            /// Represents the path of a file
            /// </summary>
            File = 0,

            /// <summary>
            /// Represents the path of a directory
            /// </summary>
            Directory = 1
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pathTargetType">Type of path to use</param>
        /// <param name="relativePath">Type of path relativity to use</param>
        public PathAttribute( Path pathTargetType = Path.File, 
                              Relativity relativePath = Relativity.ProjectRelative )
        {
            TargetType = pathTargetType;
            RelativityType = relativePath;
        }

        /// <summary>
        /// Type of path target to represent
        /// </summary>
        public Path TargetType { get; private set; }

        /// <summary>
        /// Type of path relativity to use
        /// </summary>
        public Relativity RelativityType { get; private set; }

        /// <summary>
        /// A string representing the desired relative path as defined by <see cref="RelativityType"/>
        /// </summary>
        public string RelativePath
        {
            get
            {
                switch ( RelativityType )
                {
                default:
                case Relativity.Absolute:
                    return string.Empty;

                case Relativity.AssetsRelative:
                    return string.Format( "{0}/", Application.dataPath );

                case Relativity.ProjectRelative:
                    int assetsIndex = Application.dataPath.LastIndexOf( "Assets" );
                    if ( assetsIndex >= 0 )
                    {
                        return Application.dataPath.Remove( assetsIndex );
                    }
                    return string.Empty;
                }
            }
        }
    }
}