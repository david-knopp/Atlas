using System.Collections.Generic;

namespace Atlas.Internal
{
    internal interface ISettingsItem
    {
        string Name
        {
            get;
        }

        List<string> Keywords
        {
            get;
        }

        void OnInitialize();
        void OnGUI();
    }
}