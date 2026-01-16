using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Sequence = DG.Tweening.Sequence;

public class TextEffectSequence : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private Sequence _sequence;
    
    private void Start()
    {
        _sequence = DOTween.Sequence();
        
        _sequence.Append(_text.DOText("Я заменил этот текст", _duration));
        _sequence.Append(_text.DOText("Я взломал этот текст", _duration, true, ScrambleMode.All));
        _sequence.Append(_text.DOText("Я дополнил этот текст", _duration).SetRelative());
        
        _sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
