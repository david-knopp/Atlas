using UnityEngine;

namespace Atlas
{
    /// <summary>
    /// Extension methods for Unity's <see cref="Animator"/> class
    /// </summary>
    public static class AnimatorExtensions
    {
        /// <summary>
        /// Gets the current value of the given float parameter
        /// </summary>
        /// <param name="animator">The animator to fetch the value from</param>
        /// <param name="parameter">The float parameter handle</param>
        /// <returns>The current value of the parameter</returns>
        public static float GetFloat( this Animator animator, in AnimatorFloatHandle parameter )
        {
            return animator.GetFloat( parameter.NameHash );
        }

        /// <summary>
        /// Sets the value of the given float <see cref="Animator"/> parameter
        /// </summary>
        /// <param name="animator">The animator to set the value of</param>
        /// <param name="parameter">The parameter to set</param>
        /// <param name="value">The value to set the given parameter to</param>
        public static void SetFloat( this Animator animator, in AnimatorFloatHandle parameter, float value )
        {
            animator.SetFloat( parameter.NameHash, value );
        }

        /// <summary>
        /// Gets the current value of the given bool parameter
        /// </summary>
        /// <param name="animator">The animator to fetch the value from</param>
        /// <param name="parameter">The bool parameter handle</param>
        /// <returns>The current value of the parameter</returns>
        public static bool GetBool( this Animator animator, in AnimatorBoolHandle parameter )
        {
            return animator.GetBool( parameter.NameHash );
        }

        /// <summary>
        /// Sets the value of the given boolean <see cref="Animator"/> parameter
        /// </summary>
        /// <param name="animator">The animator to set the value of</param>
        /// <param name="parameter">The parameter to set</param>
        /// <param name="value">The value to set the given parameter to</param>
        public static void SetBool( this Animator animator, in AnimatorBoolHandle parameter, bool value )
        {
            animator.SetBool( parameter.NameHash, value );
        }

        /// <summary>
        /// Gets the current value of the given integer parameter
        /// </summary>
        /// <param name="animator">The animator to fetch the value from</param>
        /// <param name="parameter">The integer parameter handle</param>
        /// <returns>The current value of the parameter</returns>
        public static int GetInteger( this Animator animator, in AnimatorIntHandle parameter )
        {
            return animator.GetInteger( parameter.NameHash );
        }

        /// <summary>
        /// Sets the value of the given integer <see cref="Animator"/> parameter
        /// </summary>
        /// <param name="animator">The animator to set the value of</param>
        /// <param name="parameter">The parameter to set</param>
        /// <param name="value">The value to set the given parameter to</param>s
        public static void SetInteger( this Animator animator, in AnimatorIntHandle parameter, int value )
        {
            animator.SetInteger( parameter.NameHash, value );
        }

        /// <summary>
        /// Sets the trigger for the given <see cref="Animator"/>
        /// </summary>
        /// <param name="animator">The animator to trigger</param>
        /// <param name="handle">The parameter to set</param>
        public static void SetTrigger( this Animator animator, in AnimatorTriggerHandle handle )
        {
            animator.SetTrigger( handle.NameHash );
        }

        /// <summary>
        /// Resets the trigger for the given <see cref="Animator"/>
        /// </summary>
        /// <param name="animator">The animator to reset the trigger of</param>
        /// <param name="handle">The trigger handle to reset</param>
        public static void ResetTrigger( this Animator animator, in AnimatorTriggerHandle handle )
        {
            animator.ResetTrigger( handle.NameHash );
        }
    }
}
