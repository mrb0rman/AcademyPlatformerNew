using UnityEngine;

namespace FallObject
{
    [CreateAssetMenu(fileName = "FallObjectSpawnConfig", menuName = "Configs/FallObjectSpawnConfig", order = 3)]
    public class FallObjectSpawnConfig : ScriptableObject
    {
        public float PositionY;
        public float MinPositionX;
        public float MaxPositionX;
        public float SpawnPeriodMin;
        public float SpawnPeriodMax;
        public float DelayStartSpawn;
    }
}


