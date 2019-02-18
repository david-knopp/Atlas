using UnityEngine;
using UnityEngine.SceneManagement;

namespace Atlas.Examples
{
    public sealed class Example_ScenePathAttribute : MonoBehaviour
    {
        // displays dropdown of scene names in inspector
        [SerializeField, ScenePath] private string m_scenePath;
        
        private void LoadScene()
        {
            // editor automatically prepares string for use with LoadScene
            SceneManager.LoadScene( m_scenePath );
        }
    }
}
