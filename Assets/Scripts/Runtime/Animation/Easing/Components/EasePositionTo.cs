using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Eases the GameObject's Transform position to the given position
    /// </summary>
    [DisallowMultipleComponent]
    public class EasePositionTo : EaseComponent
    {
        protected override void OnUpdate( float t )
        {
            Vector3 position = Vector3.LerpUnclamped( m_startPosition, m_endPosition, t );

            if ( m_useLocalPosition )
            {
                transform.localPosition = position;
            }
            else
            {
                transform.position = position;
            }
        }

        protected override void Awake()
        {
            base.Awake();
            Initialize();
        }

        [SerializeField]
        private Vector3 m_endPosition;

        [SerializeField]
        private bool m_useLocalPosition;

        private Vector3 m_startPosition;

        private void Initialize()
        {
            if ( m_useLocalPosition )
            {
                m_startPosition = transform.localPosition;
            }
            else
            {
                m_startPosition = transform.position;
            }
        }
    }
}
