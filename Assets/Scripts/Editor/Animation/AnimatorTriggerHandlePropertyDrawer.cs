using UnityEngine;
using UnityEditor;

namespace Atlas
{
    [CustomPropertyDrawer( typeof( AnimatorTriggerHandle ) )]
    public sealed class AnimatorTriggerHandlePropertyDrawerBase : AnimatorParameterHandlePropertyDrawerBase
    {
        public override AnimatorControllerParameterType? ParameterTypeFilter =>
            AnimatorControllerParameterType.Trigger;
    }
}
