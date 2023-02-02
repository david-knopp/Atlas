using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Eases the GameObject's Transform scale to the given scale
    /// </summary>
    [DisallowMultipleComponent]
    public class EaseScaleTo : EaseComponent
    {
        protected override void OnUpdate( float t )
        {
            transform.localScale = Vector3.LerpUnclamped( m_startScale, m_endScale, t );
        }

        protected override void Awake()
        {
            base.Awake();
            m_startScale = transform.localScale;
        }

        [SerializeField]
        private Vector3 m_endScale = Vector3.one;

        private Vector3 m_startScale;

        private void Reset()
        {
            m_endScale = transform.localScale;
        }
    }
}
