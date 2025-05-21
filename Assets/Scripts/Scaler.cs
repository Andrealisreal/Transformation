using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _maxSize = 3f;
    [SerializeField] private float _minSize = 1f;

    private int _direction = -1;

    private void Update()
    {
        float scaleChange = _speed * Time.deltaTime;

        transform.localScale += Vector3.one * scaleChange;

        if (transform.localScale.x >= _maxSize)
            _speed *= _direction;
        else if (transform.localScale.x <= _minSize)
            _speed *= _direction;
    }
}
