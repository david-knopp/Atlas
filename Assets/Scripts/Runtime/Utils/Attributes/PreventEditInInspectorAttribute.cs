using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Prevents the target field from being edited in the inspector window while
    /// still maintaining its visiblity
    /// </summary>
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public sealed class PreventEditInInspectorAttribute : PropertyAttribute
    {
    }
}