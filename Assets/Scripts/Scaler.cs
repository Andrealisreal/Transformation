using UnityEngine;
using DG.Tweening;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _duration = 1f;
    [SerializeField] private float _maxSize = 3f;

    private void Start()
    {
        transform.DOScale(_maxSize, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
