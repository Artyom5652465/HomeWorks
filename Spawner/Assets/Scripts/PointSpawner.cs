using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    [SerializeField] private int _repeats;
    [SerializeField] private int _pause;
    [SerializeField] private GameObject _circle;

    private GameObject[] _points;
    private float _time = 0;

    private void Start()
    {
        _points = GameObject.FindGameObjectsWithTag("Point");
    }

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= _pause)
        {
            _time = 0;
            Spawn(_points[Random.Range(0, _points.Length)]);
        }
    }

    private void Spawn(GameObject point)
    {
        GameObject circle = Instantiate(_circle, point.transform.position, Quaternion.identity);

        CircleMovement circleMovement = circle.GetComponent<CircleMovement>();
        circleMovement.SetDirection(point.GetComponent<Point>().GetDirection());
    }
}
