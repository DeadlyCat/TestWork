using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private Recorder—reated—ubes _recorder—reated—ubes;
    [SerializeField] private VerificatorAnswer _verificatorAnswer;
    [SerializeField] private ActiveLevel _activeLevel;
    public void Spawn(CubeData setupData,Transform parent)
    {  
        GameObject newCube = Instantiate(_cubePrefab, parent);

        
        newCube.GetComponent<Cube>().SetCubeData(setupData);
        newCube.GetComponent<CubeEvents>().SetVarificatorAnswerLink(_verificatorAnswer);
        newCube.GetComponent<CubeEvents>().SetActiveLevelLink(_activeLevel);
    }
}
 