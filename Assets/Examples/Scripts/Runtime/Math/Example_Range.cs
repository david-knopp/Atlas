using UnityEngine;

namespace Atlas.Examples
{
    public sealed class Example_Range
    {
        // generic character class
        public class Character
        {
            public void ApplyDamage( float damage ) { /* ... */ }
        }

        public void OnCharacterHit( Character hitCharacter )
        {
            // get randomized damage amount
            float damageAmount = m_damageRange.GetRandomValue();

            // apply damage
            hitCharacter.ApplyDamage( damageAmount );
        }

        // range declaration
        [SerializeField] private Range m_damageRange = new Range( 6f, 20f );
    }
}
