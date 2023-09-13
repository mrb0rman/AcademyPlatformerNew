﻿using AcademyPlatformerNew.Sounds;
using Zenject;

namespace AcademyPlatformerNew.Installer
{
    public class SoundInstaller : Installer<SoundInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<SoundConfig>()
                .FromScriptableObjectResource(ResourcesConst.SoundConfig)
                .AsSingle()
                .NonLazy();

            Container
                .Bind<SoundController>()
                .AsSingle()
                .NonLazy();

            Container
                .BindMemoryPool<SoundView, SoundView.Pool>()
                .FromComponentInNewPrefabResource(ResourcesConst.SoundView)
                .UnderTransformGroup("SoundPool");
        }
    }
}