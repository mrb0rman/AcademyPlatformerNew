namespace AcademyPlatformerNew.UI.UIWindow
{
    public class UIGameWindowController
    {
        private readonly UIService.UIService _uiService;
        
        private UIGameWindow _GameWindow;

        public UIGameWindowController(UIService.UIService uiService)
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