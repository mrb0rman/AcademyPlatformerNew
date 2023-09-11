using UnityEngine;

namespace AcademyPlatformerNew.UI.UIService
{
    public abstract class UIWindow : MonoBehaviour, IUIWindow
    {
        public IUIService UIService { get; set; }
        
        public abstract void Show();
        public abstract void Hide();
    }
}