using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed = 1.5f;
    [SerializeField] private float _minX = -3f;
    [SerializeField] private float _maxX = 3f;

    private int _direction = 1;

    private void Update()
    {
        transform.Translate(GetDirection() * _speed * Time.deltaTime);
    }

    private Vector3 GetDirection()
    {
        if (transform.position.x >= _maxX)
            _direction = -1;
        else if (transform.position.x <= _minX)
            _direction = 1;

        return Vector3.right * _direction;
    }
}
