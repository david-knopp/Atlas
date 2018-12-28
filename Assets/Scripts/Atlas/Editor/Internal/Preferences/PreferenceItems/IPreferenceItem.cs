namespace Atlas.Internal
{
    internal interface IPreferenceItem
    {
        string Name
        {
            get;
        }

        void OnInitialize();
        void OnGUI();
    }
}