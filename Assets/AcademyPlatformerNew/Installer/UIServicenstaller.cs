using AcademyPlatformerNew.UI.UIService;
using Zenject;

namespace AcademyPlatformerNew.Installer
{
    public class UIServicenstaller : Installer<UIServicenstaller>
    {
        public override void InstallBindings()
        {
            Container
                .BindInterfacesAndSelfTo<UIRoot>()
                .FromComponentInNewPrefabResource(ResourcesConst.UIRootPrefab)
                .AsSingle()
                .NonLazy();

            Container
                .BindInterfacesAndSelfTo<UIService>()
                .AsSingle();
        }
    }
}