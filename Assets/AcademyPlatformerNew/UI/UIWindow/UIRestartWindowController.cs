namespace AcademyPlatformerNew.UI.UIWindow
{
    public class UIRestartWindowController
    {
        private readonly UIService.UIService _uiService;
        
        private UIRestartWindow _uiRestartWindow;

        public UIRestartWindowController(UIService.UIService uiService)
        {
            _uiService = uiService;

            _uiRestartWindow = _uiService.Get<UIRestartWindow>();
        }
        
        private void ShowWindow()
        {
            _uiRestartWindow.OnReturnButtonClickEvent += ShowGameWindows;
        }
        private void HideWindow()
        {
            _uiRestartWindow.OnReturnButtonClickEvent -= ShowGameWindows;
        }

        public void ShowGameWindows()
        {
            _uiService.Hide<UIRestartWindow>();
            _uiService.Show<UIGameWindow>();
        }
    }
}