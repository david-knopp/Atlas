using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Automatically adds a button in the inspector that executes the marked function on click.
    /// </summary>
    [AttributeUsage( AttributeTargets.Method, AllowMultiple = false )]
    public sealed class InspectorButtonAttribute : PropertyAttribute
    {
    }
}
