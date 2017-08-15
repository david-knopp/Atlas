using UnityEngine;

namespace Atlas
{
    public class FixedTimer : Timer
    {
        #region protected
        protected override float CurrentTime
        {
            get { return Time.fixedTime; }
        }
        #endregion // protected
    }
}