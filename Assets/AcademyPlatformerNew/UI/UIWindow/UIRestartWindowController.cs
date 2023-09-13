using AcademyPlatformerNew.UI.UIService;

namespace AcademyPlatformerNew.UI.UIWindow
{
    public class UIRestartWindowController
    {
        private readonly IUIService _uiService;
        
        private UIRestartWindow _uiRestartWindow;

        public UIRestartWindowController(IUIService uiService)
        {
            _uiService = uiService;

            _uiRestartWindow = _uiService.Get<UIRestartWindow>();

            _uiRestartWindow.OnShowEvent += ShowWindow;
            _uiRestartWindow.OnHideEvent += HideWindow;
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