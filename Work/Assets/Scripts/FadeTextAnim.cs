using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
enum FadeType
{
    FadeIn,
    FadeOut
}
public class FadeTextAnim : DotTweenAnim
{
    [SerializeField] private Text _text;
    [SerializeField] FadeType _fadeType;
    public override void Animation(Sequence sequence,float duraction)
    {
        sequence = DOTween.Sequence();
        if (_fadeType == FadeType.FadeIn)
        {
            Fade(sequence, 0f, 1f, duraction);
        }
        if (_fadeType == FadeType.FadeOut)
        {
            Fade(sequence, 1f, 0f, duraction);
        }
    }
    private void Fade(Sequence sequence, float startOpacity,float finalOpacity,float duraction)
    {
        sequence.Append(_text.DOFade(startOpacity, 0.01f));
        sequence.Append(_text.DOFade(finalOpacity, duraction));
    }
}
