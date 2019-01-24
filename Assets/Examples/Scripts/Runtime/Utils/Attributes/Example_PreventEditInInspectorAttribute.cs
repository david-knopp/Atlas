using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_PreventEditInInspectorAttribute : MonoBehaviour
    {
        [SerializeField, PreventEditInInspector] private int m_uneditableField;
    }
}