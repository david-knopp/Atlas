using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_PreventEditInInspectorAttribute : MonoBehaviour
    {
        // field is displayed in inspector, but is greyed out and can't be edited
        [SerializeField, PreventEditInInspector] private int m_uneditableField;
    }
}
