using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Eases the GameObject's Transform rotation to the given rotation,
    /// using quaternion interpolation
    /// </summary>
    [DisallowMultipleComponent]
    public class EaseRotationTo : EaseComponent
    {
        protected override void OnUpdate( float t )
        {
            Quaternion rotation = Quaternion.SlerpUnclamped( m_startRotation, m_endRotation, t );

            if ( m_useLocalRotation )
            {
                transform.localRotation = rotation;
            }
            else
            {
                transform.rotation = rotation;
            }
        }

        protected override void Awake()
        {
            base.Awake();
            Initialize();
        }

        [SerializeField]
        private Vector3 m_endRotationDegrees;

        [SerializeField]
        private bool m_useLocalRotation;

        private Quaternion m_startRotation;
        private Quaternion m_endRotation;

        private void Initialize()
        {
            if ( m_useLocalRotation )
            {
                m_startRotation = Quaternion.Euler( transform.localRotation.eulerAngles );
            }
            else
            {
                m_startRotation = Quaternion.Euler( transform.rotation.eulerAngles );
            }

            m_endRotation = Quaternion.Euler( m_endRotationDegrees );
        }
    }
}
