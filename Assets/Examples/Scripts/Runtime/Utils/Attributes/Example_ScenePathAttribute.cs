using UnityEngine;
using UnityEngine.SceneManagement;

namespace Atlas.Examples
{
    public sealed class Example_ScenePathAttribute : MonoBehaviour
    {
        [SerializeField, ScenePath] private string m_scenePath;
        
        private void LoadScene()
        {
            SceneManager.LoadScene( m_scenePath );
        }
    }
}