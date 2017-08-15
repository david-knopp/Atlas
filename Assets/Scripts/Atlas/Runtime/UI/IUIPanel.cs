namespace Atlas
{
    public interface IUIPanel
    {
        bool IsActive { get; set; }

        void OnPush( bool doTransition );
        void OnPop( bool doTransition );
        void OnShow( bool doTransition );
        void OnHide( bool doTransition );
    }
}