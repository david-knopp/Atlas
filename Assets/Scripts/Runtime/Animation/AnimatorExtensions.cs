using UnityEngine;

namespace Atlas
{
    public static class AnimatorExtensions
    {
        public static float GetFloat( this Animator animator, in AnimatorFloatHandle parameter )
        {
            return animator.GetFloat( parameter.NameHash );
        }

        public static void SetFloat( this Animator animator, in AnimatorFloatHandle parameter, float value )
        {
            animator.SetFloat( parameter.NameHash, value );
        }

        public static bool GetBool( this Animator animator, in AnimatorBoolHandle parameter )
        {
            return animator.GetBool( parameter.NameHash );
        }

        public static void SetBool( this Animator animator, in AnimatorBoolHandle parameter, bool value )
        {
            animator.SetBool( parameter.NameHash, value );
        }

        public static int GetInteger( this Animator animator, in AnimatorIntHandle parameter )
        {
            return animator.GetInteger( parameter.NameHash );
        }

        public static void SetInteger( this Animator animator, in AnimatorIntHandle parameter, int value )
        {
            animator.SetInteger( parameter.NameHash, value );
        }

        public static void SetTrigger( this Animator animator, in AnimatorTriggerHandle handle )
        {
            animator.SetTrigger( handle.NameHash );
        }

        public static void ResetTrigger( this Animator animator, in AnimatorTriggerHandle handle )
        {
            animator.ResetTrigger( handle.NameHash );
        }
    }
}
