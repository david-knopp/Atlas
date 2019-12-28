using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Prevents the target field from being edited in the inspector window when in edit mode
    /// (becomes editable after entering playmode)
    /// </summary>
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public sealed class PreventEditInEditModeAttribute : PropertyAttribute
    {
    }
}
