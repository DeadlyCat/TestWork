using UnityEngine;

public class ChoiceCubeTypes : MonoBehaviour
{
    [SerializeField] private AllGroupList _allGroupList;

    private int ChoiceGroupIndex()
    {
        return  Random.Range(0, _allGroupList.GroupCubes.Length);
    }
    public GroupCubes SelectedGroup()
    {
        return _allGroupList.GroupCubes[ChoiceGroupIndex()];
    }
}
