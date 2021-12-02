using UnityEngine;
using UnityEngine.Events;
public class FindTextEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent _start;
    void Start()
    {
        _start.Invoke();
    }
}
