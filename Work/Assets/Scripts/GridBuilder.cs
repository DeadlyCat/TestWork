using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GridBuilder : MonoBehaviour
{
    [SerializeField] private List<GameObject> _rows;
    [SerializeField] private CubeSpawner _cubeSpawner;
    [SerializeField] private GameObject _grid;
    [SerializeField] private GameObject _row;
    public void BuildGrid(LevelData levelData,List<CubeData> CellData)
    {
        int rows = levelData.NumberRows;
        int colums = levelData.NumberColumns;
        int lendth = rows * colums;
        int rowSelected = 0;
        if(rows > _rows.Count)
        {
            for (int i = 0; i < rows; i++)
            {
                _rows.Add(NewRow());
            }
        }
        for (int i = 0; i < lendth; i++)
        {
            rowSelected = i / colums;
            CreateCell(CellData[i], _rows[rowSelected].transform);
        }
    }
    public void RemoveGrid()
    {
        foreach (GameObject item in _rows)
        {
            foreach (Transform child in item.transform)
            {
                Destroy(child.gameObject);
            }
            
            Destroy(item.transform.gameObject);
        }
        _rows.Clear();
    }

    private void CreateCell(CubeData data, Transform parent)
    {
        _cubeSpawner.Spawn(data,parent);
    }
    private GameObject  NewRow()
    {
        
        return Instantiate(_row, _grid.transform);
    }
    
}
