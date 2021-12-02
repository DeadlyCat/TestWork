using UnityEngine;
using UnityEngine.UI;

public class DispalyQuestionText : MonoBehaviour
{
    [SerializeField] private Text _text;

    public void SetupText(string setupText)
    {
        _text.text = setupText;
    }
}
