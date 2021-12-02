using UnityEngine;

public class VerificatorAnswer : MonoBehaviour
{
    private string _currentAnswer;
    public void GetCurrectAnswer(string answer)
    {
        _currentAnswer = answer;
    }
    public  bool Verification(string answer)
    {
        if(_currentAnswer == answer)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
