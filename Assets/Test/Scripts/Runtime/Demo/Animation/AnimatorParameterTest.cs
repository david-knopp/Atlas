using UnityEngine;

namespace Atlas
{
    public sealed class AnimatorParameterTest : MonoBehaviour
    {
        [Header( "Animators" )]
        [SerializeField] private Animator m_animator;

        [Header( "Parameters" )]
        [SerializeField] private AnimatorTriggerHandle m_trigger;
        [SerializeField] private AnimatorIntHandle m_int;
        [SerializeField] private AnimatorFloatHandle m_float;
        [SerializeField] private AnimatorBoolHandle m_bool;
    }
}
