using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Prevents the target field from being edited in the inspector window when in play mode
    /// (becomes editable after entering edit mode)
    /// </summary>
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public sealed class PreventEditInPlayModeAttribute : PropertyAttribute
    {
    }
}
