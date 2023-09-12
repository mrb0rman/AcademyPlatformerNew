using AcademyPlatformerNew.UI.UIService;
using Zenject;

namespace AcademyPlatformerNew.Installer
{
    public class UIServiceInstaller : Installer<UIServiceInstaller>
    {
        public override void InstallBindings()
        {
            UIWindowControllerInstaller.Install(Container);
            
            Container
                .Bind<IUIService>()
                .To<UIService>()
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<IUIRoot>()
                .To<UIRoot>()
                .FromComponentInNewPrefabResource(ResourcesConst.UIRootPrefab)
                .AsSingle()
                .NonLazy();
        }
    }
}