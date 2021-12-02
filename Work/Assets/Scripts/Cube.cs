using UnityEngine;
using UnityEngine.UI;
public class Cube : MonoBehaviour
{
    [SerializeField] private Image _cubeImage;
    private CubeData _cubeData;
    public CubeData CubeData => _cubeData;
    public void SetCubeData(CubeData cubeData)
    {
        _cubeData = cubeData;
        _cubeImage.sprite = _cubeData.Sprite;
    }
    
}
