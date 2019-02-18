namespace Atlas
{
    /// <summary>
    /// Interface for UI panels, meant to be used when managed by a UIStack
    /// </summary>
    /// <seealso cref="UIStack"/>
    public interface IUIPanel
    {
        /// <summary>
        /// Whether or not the panel is currently active, will be set by the UIStack
        /// </summary>
        bool IsActive { get; set; }

        /// <summary>
        /// Called when the panel is added to the UI stack
        /// </summary>
        /// <param name="doTransition">Whether or not a transition is intended</param>
        void OnPush( bool doTransition );

        /// <summary>
        /// Called when the panel is removed from the UIStack
        /// </summary>
        /// <param name="doTransition">Whether or not a transition is intended</param>
        void OnPop( bool doTransition );

        /// <summary>
        /// Called when the panel becomes the top (visible) panel in the <see cref="UIStack"/>
        /// </summary>
        /// <param name="doTransition">Whether or not a transition is intended</param>
        void OnShow( bool doTransition );

        /// <summary>
        /// Called when the panel becomes hidden in the <see cref="UIStack"/>
        /// </summary>
        /// <param name="doTransition">Whether or not a transition is intended</param>
        void OnHide( bool doTransition );
    }
}
