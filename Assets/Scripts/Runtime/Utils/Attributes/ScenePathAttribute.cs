using UnityEngine;
using System;

namespace Atlas
{
    [AttributeUsage( AttributeTargets.Field, AllowMultiple = false )]
    public sealed class ScenePathAttribute : PropertyAttribute
    {
    }
}