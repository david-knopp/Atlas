using UnityEngine;

namespace Atlas
{
    public class UnscaledTimer : Timer
    {
        #region protected
        protected override float CurrentTime
        {
            get { return Time.unscaledTime; }
        }
        #endregion // protected
    }
}