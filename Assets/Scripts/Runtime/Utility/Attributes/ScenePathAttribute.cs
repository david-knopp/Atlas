using UnityEngine;
using System;

namespace Atlas
{
    /// <summary>
    /// Marks the target string field as a scene path, and automatically provides a 
    /// dropdown in the inspector listing all scenes contained within the project. 
    /// If the scene has not yet been added to build settings, an inspector warning is
    /// displayed with the ability to add it immediately
    /// </summary>
    /// <seealso cref="PathAttribute"/>
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public sealed class ScenePathAttribute : PropertyAttribute
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="filter">Optional filter</param>
        /// <param name="folders">Optional list of project-relative folders to search in, e.g. "Assets/Scenes"</param>
        public ScenePathAttribute( string filter = null, params string[] folders )
        {
            Filter = filter;
            Folders = folders;
        }

        public string Filter;
        public readonly string[] Folders;
    }
}
