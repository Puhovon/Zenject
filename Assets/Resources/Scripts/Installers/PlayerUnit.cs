using Resources.Data;
using UnityEngine;
using Zenject;

namespace Resources.Scripts.Installers
{
    public class PlayerUnit : MonoBehaviour
    {
        [Inject] private IPlayerStats _config;
        private int _health;
        
        private void Start()
        {
            _health = _config.playerHealth;
            print(_health);
        }
    }
}