using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_MaxValueAttribute : MonoBehaviour
    {
        [SerializeField, MaxValue( 10.0f )] private float m_value;
    }
}