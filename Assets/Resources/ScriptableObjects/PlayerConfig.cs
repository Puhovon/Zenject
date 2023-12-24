using UnityEngine;

namespace Resources.Data
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/PlayerConfig", order = 1)]
    public class PlayerConfig : ScriptableObject, IPlayerStats
    {
        public int health;
        public int level;
        public int playerHealth { get => health;}
        public int playerLevel { get => level;}
    }
}
