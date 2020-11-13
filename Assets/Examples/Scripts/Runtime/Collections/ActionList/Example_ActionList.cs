using System;
using System.Collections.Generic;
using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_ActionList : MonoBehaviour
    {
        [Serializable]
        private sealed class TestAction : InterpolatedActionBase
        {
            public override bool IsBlocking => m_isBlocking;

            public override void OnStart()
            {
                base.OnStart();
                Debug.Log( $"{m_id}: Started" );
            }

            public override void OnStop()
            {
                base.OnStop();
                Debug.Log( $"{m_id}: Finished" );
            }

            protected override float LengthSeconds => m_lengthSeconds;

            protected override void OnTick( float elapsedPercent )
            {
                Debug.Log( $"{m_id}: {elapsedPercent * 100f}% elapsed" );
            }

            [SerializeField, MinValue( 0f )] private float m_lengthSeconds = 1f;
            [SerializeField] private string m_id;
            [SerializeField] private bool m_isBlocking = true;
        }

        [SerializeField]
        private List<TestAction> m_actions;

        private ActionList m_actionList = new ActionList();

        private void Awake()
        {
            foreach ( var action in m_actions )
            {
                m_actionList.AddLast( action );
            }
        }

        private void Update()
        {
            m_actionList.Tick();
        }
    }
}
