using UnityEngine;

using PathType = Atlas.PathAttribute.PathType;

namespace Atlas.Examples
{
    public sealed class Example_PathAttribute : MonoBehaviour
    {
        [SerializeField, Path( PathType.ProjectRelative )] private string m_path;
    }
}