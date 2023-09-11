namespace AcademyPlatformerNew.UI.UIService
{
    public interface IUIService
    {
        T Show<T>() where T: UIWindow;
        void Hide<T>() where T : UIWindow;
        T Get<T>() where T : UIWindow;

        void InitWindows();
        void LoadWindows();
    }
}