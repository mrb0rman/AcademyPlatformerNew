using System;
using UnityEngine;

namespace AcademyPlatformerNew.UI.UIWindow
{
    public class UIRestartWindow : UIService.UIWindow
    {
        public Action OnReturnButtonClickEvent;
        
        [SerializeField] private UIButton returnButton;
        
        public override void Show()
        {
            returnButton.OnClickButton += StartReturnButtonClickEvent;
        }

        public override void Hide()
        {
            returnButton.OnClickButton -= StartReturnButtonClickEvent;
        }
        
        private void StartReturnButtonClickEvent()
        {
            OnReturnButtonClickEvent.Invoke();
        }
    }
}