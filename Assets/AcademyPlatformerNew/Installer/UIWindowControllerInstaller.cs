using AcademyPlatformerNew.UI.HUD;
using AcademyPlatformerNew.UI.UIService;
using AcademyPlatformerNew.UI.UIWindow;
using Zenject;

namespace AcademyPlatformerNew.Installer
{
    public class UIWindowControllerInstaller : Installer<UIWindowControllerInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<UIMainMenuWindowController>()
                .AsSingle()
                .NonLazy();

            Container
                .BindInterfacesAndSelfTo<UIGameWindowController>()
                .AsSingle()
                .NonLazy();

            Container
                .BindInterfacesAndSelfTo<UIRestartWindowController>()
                .AsSingle()
                .NonLazy();
            
            Container
                .BindInterfacesAndSelfTo<HUDWindowController>()
                .AsSingle()
                .NonLazy();
        }
    }
}