using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Eases the GameObject's Transform rotation to the given rotation
    /// </summary>
    public class EaseRotationTo : EaseComponent
    {
        protected override void OnUpdate( float t )
        {
            Vector3 eulerAngles = Vector3.SlerpUnclamped( m_startRotation, m_endRotationDegrees, t );
            Quaternion rotation = Quaternion.Euler( eulerAngles );

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

        private Vector3 m_startRotation;

        private void Initialize()
        {
            if ( m_useLocalRotation )
            {
                m_startRotation = transform.localRotation.eulerAngles;
            }
            else
            {
                m_startRotation = transform.rotation.eulerAngles;
            }
        }

        private void OnValidate()
        {
            Initialize();
        }
    }
}
