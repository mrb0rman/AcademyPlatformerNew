using AcademyPlatformerNew.UI.UIWindow;
using Zenject;

namespace AcademyPlatformerNew.Installer
{
    public class UIWindowControllerInstaller : Installer<UIWindowControllerInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .BindInterfacesAndSelfTo<UIMainMenuWindowController>()
                .AsSingle();

            Container
                .BindInterfacesAndSelfTo<UIGameWindowController>()
                .AsSingle();

            Container
                .BindInterfacesAndSelfTo<UIRestartWindowController>()
                .AsSingle();
        }
    }
}