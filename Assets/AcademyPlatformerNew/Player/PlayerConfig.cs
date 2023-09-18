using System;
using UnityEngine;

namespace AcademyPlatformerNew.Player
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/PlayerConfig", order = 0)]
    public class PlayerConfig : ScriptableObject
    {
        public PlayerModel PlayerModel => playerModel;
        
        [SerializeField] private PlayerModel playerModel;
    }

    [Serializable]
    public struct PlayerModel
    {
        public Sprite Sprite;
        
        public float Health;
        public float Speed;
    }
}