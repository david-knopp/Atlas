using System;
using UnityEngine;

namespace Atlas
{
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public sealed class PreventEditInInspectorAttribute : PropertyAttribute
    {
    }
}