using UnityEngine;
using DG.Tweening;
public abstract class DotTweenAnim : MonoBehaviour
{
    private Sequence _sequence;
    [SerializeField] private float _duraction;
    public virtual void StartAnim()
    {
        Animation(_sequence, _duraction);
        
    }
    public abstract void Animation(Sequence sequence,float duraction);
}
