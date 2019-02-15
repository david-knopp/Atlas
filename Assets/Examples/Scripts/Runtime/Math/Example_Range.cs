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
        [SerializeField] private Range m_damageRange 
            = new Range() { m_minValue = 6f, m_maxValue = 20f };
    }
}