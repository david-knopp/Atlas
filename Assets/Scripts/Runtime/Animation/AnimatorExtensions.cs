using UnityEngine;

namespace Atlas
{
    public static class AnimatorExtensions
    {
        public static void SetFloat( this Animator animator, in AnimatorFloatHandle parameter, float value )
        {
            animator.SetFloat( parameter.NameHash, value );
        }

        public static void SetBool( this Animator animator, in AnimatorBoolHandle parameter, bool value )
        {
            animator.SetBool( parameter.NameHash, value );
        }

        public static void SetInteger( this Animator animator, in AnimatorIntHandle parameter, int value )
        {
            animator.SetInteger( parameter.NameHash, value );
        }

        public static void SetTrigger( this Animator animator, in AnimatorTriggerHandle handle )
        {
            animator.SetTrigger( handle.NameHash );
        }
    }
}
