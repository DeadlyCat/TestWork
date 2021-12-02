using UnityEngine;
using System;

[Serializable]
public class LevelData
{   
    [Tooltip("Количество строк с кубиками")]
    [SerializeField] private int _numberRows;
    public int NumberRows => _numberRows;

    [Tooltip("Количество колонок с кубиками")]
    [SerializeField] private int _numberColumns;
    public int NumberColumns => _numberColumns;
}
