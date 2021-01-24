using UnityEngine;
using UnityEditor;

namespace Atlas
{
    [CustomPropertyDrawer( typeof( AnimatorBoolHandle ) )]
    public sealed class AnimatorBoolHandlePropertyDrawerBase : AnimatorParameterHandlePropertyDrawerBase
    {
        public override AnimatorControllerParameterType? ParameterTypeFilter =>
            AnimatorControllerParameterType.Bool;
    }
}
