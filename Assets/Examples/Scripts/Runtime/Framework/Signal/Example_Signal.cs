namespace Atlas.Examples
{
    public sealed class Example_Signal
    {
        public enum CharacterState
        {
            Alive,
            Dead
        }

        // signal declaration
        public class CharacterStateChangedSignal : Signal<CharacterState>
        {
        }

        // called externally to provide relevant dependencies
        public void OnInjectDependencies( CharacterStateChangedSignal signal )
        {
            m_signal = signal;
        }

        public void TakeDamage( int damage )
        {
            m_curHealth -= damage;
            if ( m_curHealth <= 0 )
            {
                // dispatches state change to all listeners
                m_signal.Dispatch( CharacterState.Dead );
            }
        }

        private CharacterStateChangedSignal m_signal;
        private int m_curHealth;
    }
}
