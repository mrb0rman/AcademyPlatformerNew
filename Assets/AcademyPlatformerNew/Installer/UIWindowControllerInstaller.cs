using UI.HUD;
using UI.UIWindows;
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
                .Bind<UIGameWindowController>()
                .AsSingle()
                .NonLazy();

            Container
                .Bind<UIRestartWindowController>()
                .AsSingle()
                .NonLazy();

            Container
                .Bind<HUDWindowController>()
                .AsSingle()
                .NonLazy();
        }
    }
}