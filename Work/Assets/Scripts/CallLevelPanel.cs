using UnityEngine;

public class CallLevelPanel : MonoBehaviour
{
    [SerializeField] private GameObject _finalPanel;
    private void Start()
    {
        _finalPanel.SetActive(false);
    }
    public void CallPanel()
    {
        _finalPanel.SetActive(true);
    }
}
