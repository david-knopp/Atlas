using UnityEngine;
using UnityEditor;

namespace Atlas
{
    [CustomPropertyDrawer( typeof( AnimatorFloatHandle ) )]
    public sealed class AnimatorFloatHandlePropertyDrawerBase : AnimatorParameterHandlePropertyDrawerBase
    {
        public override AnimatorControllerParameterType? ParameterTypeFilter =>
            AnimatorControllerParameterType.Float;
    }
}
