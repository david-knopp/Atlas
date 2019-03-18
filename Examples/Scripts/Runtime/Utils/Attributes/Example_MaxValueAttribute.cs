using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_MaxValueAttribute : MonoBehaviour
    {
        // prevents assigning values > 10 in the inspector
        [SerializeField, MaxValue( 10.0f )] private float m_value;
    }
}
