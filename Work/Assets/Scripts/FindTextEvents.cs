using UnityEngine;
using UnityEngine.Events;
public class FindTextEvents : MonoBehaviour
{
    [SerializeField] private UnityEvent _start;
    private void Start()
    {
        _start.Invoke();
    }
}
