using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 180f;
    [SerializeField] private Vector3 _rotationAngle;

    private void Start()
    {
        var duration = 360f / _rotationSpeed;
        
        transform.DORotate(_rotationAngle, duration, RotateMode.LocalAxisAdd).SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
    }
}
