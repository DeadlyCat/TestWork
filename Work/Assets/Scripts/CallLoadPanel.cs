using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CallLoadPanel : MonoBehaviour
{
    [SerializeField] private GameObject _loadPanel;
    void Start()
    {
        _loadPanel.SetActive(false);
    }
    public void SceneLoad()
    {
        _loadPanel.SetActive(true);
        
    }
    public void SceneLoaded()
    {
        _loadPanel.SetActive(false);

    }
}
