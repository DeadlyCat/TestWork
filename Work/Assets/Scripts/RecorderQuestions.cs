using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecorderQuestions : MonoBehaviour
{
    [SerializeField] private List<string> _levelQuestions = new List<string>(0);
    public List<string> LevelQuestions => _levelQuestions;

    public void GenerateLvlQuestion(List<CubeData> initialData)
    {
        string indentifier = GenerateUniqueValue(initialData);
        Add(indentifier);
    }
    private void Add(string addData)
    {
        _levelQuestions.Add(addData);
    }
    private string GenerateUniqueValue(List<CubeData> initialData)
    {
        int index = Random.Range(0, initialData.Count);
        string indentifier = initialData[index].Identifier;
        if (IsUniqueValue(indentifier) == true)
        {
            return indentifier;
        }
        else
        {
            return GenerateUniqueValue(initialData);
        }
    }
    private bool IsUniqueValue(string newindentifie)
    {
        if (_levelQuestions.Count > 0)
        {
            foreach (string item in _levelQuestions)
            {
                if (newindentifie == item)
                {
                    return false;
                }
            }
            return true;
        }
        else
        {
            return true;
        }
    }
}
