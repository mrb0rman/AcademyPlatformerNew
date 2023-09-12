using System;
using UnityEngine;

namespace AcademyPlatformerNew.UI.UIWindow
{
    public class UIMainMenuWindow : UIService.UIWindow
    {
        public Action OnStartButtonClickEvent;
        
        [SerializeField] private UIButton startButton;
        
        public override void Show()
        {
            startButton.OnClickButton += StartButtonClickEvent; 
        }

        public override void Hide()
        {
            startButton.OnClickButton -= StartButtonClickEvent;
        }

        private void StartButtonClickEvent()
        {
            OnStartButtonClickEvent?.Invoke();
        }
    }
}