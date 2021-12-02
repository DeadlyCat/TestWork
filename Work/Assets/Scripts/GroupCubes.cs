using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewCardBundleData" , menuName ="CardBundleData",order =10)]
public class GroupCubes : ScriptableObject
{
    [SerializeField] private CubeData[] _cubeData;
    public CubeData[] CubeData => _cubeData;
}
