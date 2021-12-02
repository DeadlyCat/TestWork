using UnityEngine;
using UnityEngine.Events;
public class ActiveLevel : MonoBehaviour
{
    [SerializeField] private GroupLevel _groupLevel;
    [SerializeField] private GridBuilder _gridBuilder;
    [SerializeField] private ChoiceCubeTypes _choiceCubeTypes;
    [SerializeField] private RecorderСreatedСubes _recorderСreatedСubes;
    [SerializeField] private RecorderQuestions _recorderQuestions;
    [SerializeField] private DispalyQuestionText dispalyQuestionText;
    [SerializeField] private VerificatorAnswer _verificatorAnswer;
    [SerializeField] private CallLevelPanel _callLevelPanel;
    [SerializeField] private UnityEvent _compiteAllLevels;
    [SerializeField] private int _levelIndex = 1;
    public int LevelIndex => _levelIndex;
   
    private string _answerQuestion;
    private LevelData _level;
    private GroupCubes _selectedGroup;
    private void Start()
    {
        _level = _groupLevel.LevelData[_levelIndex];
        BuidLvl(_level);
    }
    private void BuidLvl(LevelData level)
    {
        _selectedGroup = _choiceCubeTypes.SelectedGroup();
        _recorderСreatedСubes.GenerateList(_level.NumberColumns * _level.NumberRows,_selectedGroup);
        _recorderQuestions.GenerateLvlQuestion(_recorderСreatedСubes.CreatedCubes);
        _answerQuestion = _recorderQuestions.LevelQuestions[_recorderQuestions.LevelQuestions.Count -1];
        _gridBuilder.BuildGrid(level, _recorderСreatedСubes.CreatedCubes);
        dispalyQuestionText.SetupText(_answerQuestion);
        _verificatorAnswer.GetCurrectAnswer(_answerQuestion);
    }
    public void LoadNextLvl()
    {
        _levelIndex += 1;
        if (_levelIndex >=_groupLevel.LevelData.Length)
        {
            _compiteAllLevels.Invoke();
        }
        else
        {
            _recorderСreatedСubes.Clear();
            _level = _groupLevel.LevelData[_levelIndex];
            _gridBuilder.RemoveGrid();
            BuidLvl(_level);
        }
        
    }
}
