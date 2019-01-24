using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_ProfilerScope : MonoBehaviour
    {
        private void Update()
        {
            using ( new ProfilerScope( "Example" ) )
            {
                // code to measure...
            }
        }
    }
}