using UnityEngine;
using DG.Tweening;
public class BounceAnim : DotTweenAnim
{
    public override void Animation(Sequence sequence,float ducraction)
    {
        sequence = DOTween.Sequence();
        sequence.Append(transform.DOScale(new Vector2(0, 0), ducraction));
        sequence.Append(transform.DOScale(new Vector2(1.2f, 1.2f), ducraction));
        sequence.Append(transform.DOScale(new Vector2(0.95f, 0.95f), ducraction));
        sequence.Append(transform.DOScale(new Vector2(1f, 1f), ducraction));
    }


}
