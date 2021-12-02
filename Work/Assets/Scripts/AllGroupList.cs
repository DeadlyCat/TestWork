using UnityEngine;
[CreateAssetMenu(fileName = "AllGroupList", menuName = "AllGroupList", order = 10)]
public class AllGroupList : ScriptableObject
{
    [SerializeField] private GroupCubes[] _groupCubes;
    public GroupCubes[] GroupCubes => _groupCubes;
}
