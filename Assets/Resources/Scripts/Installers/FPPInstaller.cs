using System;
using Resources.Data;
using UnityEngine;
using Zenject;

namespace Resources.Scripts.Installers
{
    public class FPPInstaller : MonoInstaller
    {
        [SerializeField] private PlayerUnit playerUnit;
        [SerializeField] private Transform playerSpawnPoint;
        [SerializeField] private PlayerConfig config;
        private IPlayerStats _playerStats;
        [SerializeField] private bool useScriptableObject = false;
       
        public override void InstallBindings()
        {
            _playerStats = useScriptableObject ? config : new PlayerConfigClass();
            Container.Bind<IPlayerStats>().FromInstance(_playerStats).AsSingle().NonLazy();
            var playerInstance = Container.InstantiatePrefabForComponent<PlayerUnit>(playerUnit, playerSpawnPoint.position,
                Quaternion.identity, null);

            Container.Bind<PlayerUnit>().FromInstance(playerInstance).AsSingle().NonLazy();

        }
    }
}