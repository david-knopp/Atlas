using System;
using UnityEngine;

namespace Atlas
{
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public class PathAttribute : PropertyAttribute
    {
        public enum PathType
        {
            Absolute = 0,
            AssetsRelative = 1,
            ProjectRelative = 2
        }

        public PathAttribute( PathType relativePath = PathType.ProjectRelative )
        {
            Type = relativePath;
        }

        public PathType Type { get; private set; }

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