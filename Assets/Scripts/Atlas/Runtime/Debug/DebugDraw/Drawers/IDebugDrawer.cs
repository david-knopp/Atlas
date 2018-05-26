using UnityEngine;

namespace Atlas
{
    public interface IDebugDrawer
    {
        bool IsFinished
        {
            get;
        }

        Color Color
        {
            get;
            set;
        }

        void Draw();
    }
}