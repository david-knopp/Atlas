using UnityEngine;

namespace Atlas
{
    public sealed class Example_InspectorButton : MonoBehaviour
    {
        [InspectorButton]
        private void Print()
        {
            Debug.Log( "Hi, how are ya?" );
        }
    }
}
