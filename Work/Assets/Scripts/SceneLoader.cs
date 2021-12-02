using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private CallLoadPanel callLoadPanel;
    
    public void RestartGame()
    {
       
        callLoadPanel.SceneLoad();
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
         AsyncOperation _load = SceneManager.LoadSceneAsync(0);
        callLoadPanel.SceneLoad();
        yield return _load.isDone;
        callLoadPanel.SceneLoaded();
    }
    
    
}
