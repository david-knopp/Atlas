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
        public enum PathType
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
        /// Constructor
        /// </summary>
        /// <param name="relativePath">Type of path relativity to use</param>
        public PathAttribute( PathType relativePath = PathType.ProjectRelative )
        {
            Type = relativePath;
        }

        /// <summary>
        /// Type of path relativity to use
        /// </summary>
        public PathType Type { get; private set; }

        /// <summary>
        /// A string representing the desired relative path as defined by <see cref="Type"/>
        /// </summary>
        public string RelativePath
        {
            get
            {
                switch ( Type )
                {
                default:
                case PathType.Absolute:
                    return string.Empty;

                case PathType.AssetsRelative:
                    return string.Format( "{0}/", Application.dataPath );

                case PathType.ProjectRelative:
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