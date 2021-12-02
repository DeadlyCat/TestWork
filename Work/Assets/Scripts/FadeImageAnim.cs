using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class FadeImageAnim : DotTweenAnim
{
    [SerializeField] Image _image;
    [SerializeField] private float _startOpacity;
    [SerializeField] private float _finalOpacity;
    public override void Animation(Sequence sequence, float duraction)
    {
        sequence = DOTween.Sequence();
        Fade(sequence, _startOpacity, _finalOpacity, duraction);
    }
    void Fade(Sequence sequence, float startOpacity, float finalOpacity, float duraction)
    {
        sequence.Append(_image.DOFade(startOpacity,0));
        sequence.Append(_image.DOFade(finalOpacity, duraction));
    }
}
