using UnityEngine;
using UnityEngine.UI;

public class DispalyQuestionText : MonoBehaviour
{
    [SerializeField] Text _text;

    public void SetupText(string setupText)
    {
        _text.text = setupText;
    }
}
