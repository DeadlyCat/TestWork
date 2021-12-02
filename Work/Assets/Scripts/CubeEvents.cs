using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class CubeEvents : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private UnityEvent _rightAnswer;
    [SerializeField] private UnityEvent _wrongAnswer;
    [SerializeField] private CubeData _cube;
    [SerializeField] private VerificatorAnswer _verificatorAnswer;
    [SerializeField] private ActiveLevel _activeLevel;
    private void Start()
    {
        _cube = GetComponent<Cube>().CubeData;
    }
    public void SetVarificatorAnswerLink(VerificatorAnswer varificator)
    {
        _verificatorAnswer = varificator;
    }
    public void SetActiveLevelLink(ActiveLevel active)
    {
        _activeLevel = active;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (_verificatorAnswer.Verification(_cube.Identifier) == true)
        {
            _rightAnswer.Invoke();
            _activeLevel.LoadNextLvl();
        }
        else
        {
            _wrongAnswer.Invoke();
        }
    }
}
