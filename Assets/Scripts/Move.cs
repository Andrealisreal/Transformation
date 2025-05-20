using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed = 1.5f;
    [SerializeField] private float _minX = -3f;
    [SerializeField] private float _maxX = 3f;

    private int _direction = 1;

    void Update()
    {
        Vector3 position = transform.position;
        position.x += _direction * _speed * Time.deltaTime;
        transform.position = position;

        if (position.x >= _maxX)
            _direction = -1;
        else if (position.x <= _minX)
            _direction = 1;
    }
}
