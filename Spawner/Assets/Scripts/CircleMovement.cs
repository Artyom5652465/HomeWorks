using UnityEngine;

[RequireComponent(typeof(Vector3))]

public class CircleMovement : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private float _speed;

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    private void Update()
    {
        transform.Translate(_direction.normalized * _speed * Time.deltaTime);
    }
}
