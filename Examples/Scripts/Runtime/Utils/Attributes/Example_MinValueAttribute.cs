using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_MinValueAttribute : MonoBehaviour
    {
        // prevents assigning values < 0 in the inspector
        [SerializeField, MinValue( 0.0f )] private float m_value;
    }
}
