﻿using UI.UIService;
using Zenject;

namespace AcademyPlatformerNew.Installer
{
    public class UIServiceInstaller : Installer<UIServiceInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<UIRoot>()
                .FromComponentInNewPrefabResource(ResourcesConst.UIRootPrefab)
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<UIService>()
                .AsSingle()
                .NonLazy();
            
            UIWindowControllerInstaller.Install(Container);
        }
    }
}