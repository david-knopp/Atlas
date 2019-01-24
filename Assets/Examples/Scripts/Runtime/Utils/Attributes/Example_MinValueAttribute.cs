using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_MinValueAttribute : MonoBehaviour
    {
        [SerializeField, MinValue( 0.0f )] private float m_value;
    }
}