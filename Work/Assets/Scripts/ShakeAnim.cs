using UnityEngine;
using DG.Tweening;
public class ShakeAnim : DotTweenAnim
{
    [SerializeField] private float _stepShake;
    public override void Animation(Sequence sequence, float ducatction)
    {
        sequence = DOTween.Sequence();
        sequence.Append(transform.DOBlendableMoveBy(Vector3.left  * _stepShake, ducatction));
        sequence.Append(transform.DOBlendableMoveBy(Vector3.right * _stepShake, ducatction));
        sequence.Append(transform.DOBlendableMoveBy(Vector3.left  * _stepShake, ducatction));
        sequence.Append(transform.DOBlendableMoveBy(Vector3.right * _stepShake, ducatction));
        sequence.Append(transform.DOBlendableMoveBy(Vector3.left  * _stepShake, ducatction));
        sequence.Append(transform.DOBlendableMoveBy(Vector3.right * _stepShake, ducatction));
    }
}
