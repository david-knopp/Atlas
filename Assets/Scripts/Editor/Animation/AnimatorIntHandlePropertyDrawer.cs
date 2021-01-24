using UnityEngine;
using UnityEditor;

namespace Atlas
{
    [CustomPropertyDrawer( typeof( AnimatorIntHandle ) )]
    public sealed class AnimatorIntHandlePropertyDrawerBase : AnimatorParameterHandlePropertyDrawerBase
    {
        public override AnimatorControllerParameterType? ParameterTypeFilter =>
            AnimatorControllerParameterType.Int;
    }
}
