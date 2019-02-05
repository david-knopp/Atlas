using UnityEngine;

namespace Atlas.Test
{
    public sealed class AttributesTest : MonoBehaviour
    {
        [SerializeField, ScenePath] private string m_scenePath;
        [SerializeField, MaxValue( 1.0f )] private float m_floatMax;
        [SerializeField, MinValue( 0.0f )] private float m_floatMin;
        [SerializeField, MaxValue( 1 )] private int m_intMax;
        [SerializeField, MinValue( 0 )] private int m_intMin;
        [SerializeField, PreventEditInInspector] private bool m_notEditable;
    }
}