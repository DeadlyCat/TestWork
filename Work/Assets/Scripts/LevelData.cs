using UnityEngine;
using System;

[Serializable]
public class LevelData
{   
    [Tooltip("���������� ����� � ��������")]
    [SerializeField] private int _numberRows;
    public int NumberRows => _numberRows;

    [Tooltip("���������� ������� � ��������")]
    [SerializeField] private int _numberColumns;
    public int NumberColumns => _numberColumns;
}
