using UnityEngine;

using Path = Atlas.PathAttribute.Path;
using Relativity = Atlas.PathAttribute.Relativity;

namespace Atlas.Examples
{
    public sealed class Example_PathAttribute : MonoBehaviour
    {
        [Header( "Absolute" )]
        [SerializeField, Path( Path.File, Relativity.ProjectRelative )]
        private string m_filePathAbsolute;

        [SerializeField, Path( Path.Directory, Relativity.ProjectRelative )]
        private string m_directoryPathAbsolute;

        [Header( "Assets-relative" )]
        [SerializeField, Path( Path.File, Relativity.AssetsRelative )]
        private string m_filePathAssets;

        [SerializeField, Path( Path.Directory, Relativity.AssetsRelative )]
        private string m_directoryPathAssets;

        [Header( "Project-relative" )]
        [SerializeField, Path( Path.File, Relativity.ProjectRelative )]
        private string m_filePathProject;

        [SerializeField, Path( Path.Directory, Relativity.ProjectRelative )]
        private string m_directoryPathProject;
    }
}