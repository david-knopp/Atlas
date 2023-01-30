using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Eases the GameObject's Transform position to the given position
    /// </summary>
    public class EasePositionTo : EaseComponent
    {
        protected override void OnUpdate( float t )
        {
            transform.position = Vector3.LerpUnclamped( m_startPosition, m_endPosition, t );
        }

        protected override void Awake()
        {
            base.Awake();
            m_startPosition = transform.position;
        }

        [SerializeField]
        private Vector3 m_endPosition;

        private Vector3 m_startPosition;
    }
}
