using UnityEngine;
[CreateAssetMenu(fileName = "NewLevelBundleData", menuName = "LevelBundleData", order = 10)]
public class GroupLevel : ScriptableObject
{
    [SerializeField] private LevelData[] _levelData;
    public LevelData[] LevelData => _levelData;
}
