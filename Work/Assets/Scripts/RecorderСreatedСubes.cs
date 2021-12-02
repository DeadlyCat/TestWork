using System.Collections.Generic;
using UnityEngine;

public class RecorderСreatedСubes : MonoBehaviour
{
    
    [SerializeField] private List<CubeData> _createdCubes = new List<CubeData>();
    public List<CubeData> CreatedCubes => _createdCubes;

    public void GenerateList(int length,GroupCubes initialData)
    {
        for (int i = 0; i < length; i++)
        {
            CubeData cube = GenerateUniqueValue(initialData);
            Add(cube);
        }
    }
    private void Add(CubeData addData)
    {
        _createdCubes.Add(addData);
    }
    public void Clear()
    {
        _createdCubes.Clear();
    }
    private CubeData GenerateUniqueValue(GroupCubes initialData)
    {
        int index = Random.Range(0, initialData.CubeData.Length);
        CubeData cube = initialData.CubeData[index];
        if(IsUniqueValue(cube) == true)
        {
            return cube;
        }
        else
        {
            return GenerateUniqueValue(initialData);
        }
       
    }
    private bool IsUniqueValue(CubeData newCube) 
    {
        if(_createdCubes.Count >0)
        {
            foreach (CubeData item in _createdCubes)
            {
                if (newCube == item)
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
