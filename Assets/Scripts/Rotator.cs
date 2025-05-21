using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed = 50f;

    private void Update()
    {
        transform.Rotate(Vector3.up, _speed * Time.deltaTime);
    }
}
