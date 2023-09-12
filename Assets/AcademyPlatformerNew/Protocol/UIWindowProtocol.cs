using AcademyPlatformerNew.UI.UIWindow;

namespace AcademyPlatformerNew.Protocol
{
    public class UIWindowProtocol
    {
        public UIMainMenuWindow UIMainMenuWindow;
        public UIGameWindow UIGameWindow;
        public UIRestartWindow UIRestartWindow;

        public UIWindowProtocol(UIMainMenuWindow uiMainMenuWindow,
            UIGameWindow uiGameWindow,
            UIRestartWindow uiRestartWindow)
        {
            UIMainMenuWindow = uiMainMenuWindow;
            UIGameWindow = uiGameWindow;
            UIRestartWindow = uiRestartWindow;
        }
    }
}