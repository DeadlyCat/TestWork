using UnityEngine;
using UnityEngine.Events;
public class GridAnimEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent _eventStart;
    private void Start()
    {
        _eventStart.Invoke();
    }
}
