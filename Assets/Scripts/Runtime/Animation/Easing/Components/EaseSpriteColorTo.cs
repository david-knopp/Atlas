using System;
using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Eases a SpriteRenderer's color to the given color
    /// </summary>
    [DisallowMultipleComponent, RequireComponent( typeof( SpriteRenderer ) )]
    public class EaseSpriteColorTo : EaseComponent
    {
        protected override void OnUpdate( float t )
        {
            Color color = Color.LerpUnclamped( m_startColor, m_endColor, t );
            m_spriteRenderer.color = color;
        }

        protected override void Awake()
        {
            base.Awake();
            m_spriteRenderer = GetComponent<SpriteRenderer>();

            if ( m_spriteRenderer == null )
            {
                throw new InvalidOperationException( $"Failed easing sprite color: {gameObject.name} is missing a {nameof( SpriteRenderer )}" );
            }

            m_startColor = m_spriteRenderer.color;
        }

        [SerializeField]
        private Color m_endColor;

        private Color m_startColor;
        private SpriteRenderer m_spriteRenderer;
    }
}
