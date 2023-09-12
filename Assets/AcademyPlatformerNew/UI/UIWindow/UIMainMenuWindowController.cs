﻿namespace AcademyPlatformerNew.UI.UIWindow
{
    public class UIMainMenuWindowController
    {
        private readonly UIService.UIService _uiService;
        
        private UIMainMenuWindow _mainMenuWindow;

        public UIMainMenuWindowController(UIService.UIService uiService)
        {
            _uiService = uiService;
            
            _mainMenuWindow = uiService.Get<UIMainMenuWindow>();
            
            _mainMenuWindow.OnShowEvent += ShowWindow;
            _mainMenuWindow.OnHideEvent += HideWindow;
        }
        
        private void ShowWindow()
        {
            _mainMenuWindow.OnStartButtonClickEvent += ShowGameWindow;
        }
        
        private void HideWindow()
        {
            _mainMenuWindow.OnStartButtonClickEvent -= ShowGameWindow;
        }
        
        private void ShowGameWindow()
        {
            _uiService.Hide<UIMainMenuWindow>();
            _uiService.Show<UIGameWindow>();
        }
    }
}