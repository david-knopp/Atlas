using UnityEngine;

namespace Atlas.Examples
{
	public class CatapultAnimation : MonoBehaviour
    {
        public bool IsBroken
        {
            get => m_animator.GetBool( m_isBrokenParam );
            set => m_animator.SetBool( m_isBrokenParam, value );
        }

        [InspectorButton]
        public void Launch()
        {
            m_animator.SetTrigger( m_launchParam );
        }

        [InspectorButton]
        public void Break()
        {
            IsBroken = true;
        }

        [InspectorButton]
        public void Restart()
        {
            m_animator.SetTrigger( m_restartParam );
        }

        [SerializeField]
        private AnimatorBoolHandle m_isBrokenParam = "IsBroken";

        [SerializeField]
        private AnimatorTriggerHandle m_launchParam = "Launch";

        [SerializeField]
        private AnimatorTriggerHandle m_restartParam = "Restart";

        [SerializeField]
		private Animator m_animator;
	} 
}
