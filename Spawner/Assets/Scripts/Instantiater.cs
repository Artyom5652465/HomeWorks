using UnityEngine;

public class Instantiater : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private Transform _position;
    [SerializeField] private GameObject _circle;

    public void Spawn()
    {
        GameObject circle = Instantiate(_circle, _position.position, Quaternion.identity);

        CircleMovement circleMovement = circle.GetComponent<CircleMovement>();
        circleMovement.SetDirection(_direction);
    }
}
