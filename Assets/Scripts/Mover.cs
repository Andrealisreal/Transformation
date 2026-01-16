using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration = 1.5f;
    [SerializeField] private Transform _target;

    private void Start()
    {
        transform.DOMove(_target.position, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
