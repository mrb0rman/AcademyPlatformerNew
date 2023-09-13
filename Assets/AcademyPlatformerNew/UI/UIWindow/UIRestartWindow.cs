using System;
using UnityEngine;

namespace AcademyPlatformerNew.UI.UIWindow
{
    public class UIRestartWindow : UIAnimationWindow
    {
        public Action OnReturnButtonClickEvent;
        
        [SerializeField] private UIButton returnButton;
        
        public override void Show()
        {
            base.Show();
            returnButton.OnClickButton += StartReturnButtonClickEvent;
        }

        public override void Hide()
        {
            base.Hide();
            returnButton.OnClickButton -= StartReturnButtonClickEvent;
        }
        
        private void StartReturnButtonClickEvent()
        {
            OnReturnButtonClickEvent.Invoke();
        }
    }
}