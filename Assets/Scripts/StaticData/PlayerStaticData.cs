using UnityEngine;

namespace StaticData
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "StaticData/PlayerData")]
    public class PlayerStaticData : ScriptableObject
    {
        public float HorizontalHeadRotationSpeed;
        public float VerticalHeadRotationSpeed;
    }
}