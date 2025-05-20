using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private float _speed = 50f;

    void Update()
    {
        transform.Rotate(Vector3.up, _speed * Time.deltaTime);
    }
}
