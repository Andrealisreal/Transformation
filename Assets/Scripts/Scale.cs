using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _maxSize = 3f;
    [SerializeField] private float _minSize = 1f;

    private int _direction = -1;

    void Update()
    {
        float scaleChange = _speed * Time.deltaTime;

        transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);

        Vector3 current = transform.localScale;

        if (current.x >= _maxSize)
            _speed *= _direction;
        else if (current.x <= _minSize)
            _speed *= _direction;
    }
}
