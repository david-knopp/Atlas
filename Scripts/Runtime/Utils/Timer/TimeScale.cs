namespace Atlas
{
    /// <summary>
    /// Types of time scales used to reference Unity's various <see cref="UnityEngine.Time"/> methods
    /// </summary>
    public enum TimeScale
    {
        /// <summary>
        /// Uses default <see cref="UnityEngine.Time.time"/>, thus allowing the timer to 
        /// react to slow-mo effects and game pauses
        /// </summary>
        Scaled = 0,

        /// <summary>
        /// Uses <see cref="UnityEngine.Time.timeScale"/>-independent time to effectively 
        /// measure "real" time
        /// </summary>
        Unscaled = 1,

        /// <summary>
        /// Uses the current <see cref="UnityEngine.Time.fixedTime"/> to provide more 
        /// accurate time measuring inside of Unity's FixedUpdate
        /// </summary>
        Fixed = 2
    }
}
