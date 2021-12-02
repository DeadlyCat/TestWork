using System;
using UnityEngine;
[Serializable]
public class CubeData 
{
    [Tooltip("������������� ������")]
    [SerializeField] private string _identifier;
    public string Identifier => _identifier;

    [Tooltip("����������� ������")]
    [SerializeField] private Sprite _sprite;
    public Sprite Sprite => _sprite;

}
