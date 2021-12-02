using System;
using UnityEngine;
[Serializable]
public class CubeData 
{
    [Tooltip("Идентификатор кубика")]
    [SerializeField] private string _identifier;
    public string Identifier => _identifier;

    [Tooltip("Изображение кубика")]
    [SerializeField] private Sprite _sprite;
    public Sprite Sprite => _sprite;

}
