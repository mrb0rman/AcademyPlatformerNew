using AcademyPlatformerNew.UI.UIService;

namespace AcademyPlatformerNew.UI.UIWindow
{
    public class UIGameWindowController
    {
        private readonly IUIService _uiService;
        
        private UIGameWindow _GameWindow;

        public UIGameWindowController(IUIService uiService)
        {
            _uiService = uiService;
            _GameWindow = uiService.Get<UIGameWindow>();
        }

        public void ShowRestartWindow()
        {
            _uiService.Hide<UIGameWindow>();
            //_uiService.Hide<HUDWindow>();
            _uiService.Show<UIRestartWindow>();
        }
    }
}