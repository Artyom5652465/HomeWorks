using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    [SerializeField] private int _repeats;
    [SerializeField] private int _pause;

    private Insantiater[] _points;
    private float _time = 0;

    private void Start()
    {
        _points = GameObject.FindObjectsOfType<Insantiater>();
    }

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= _pause)
        {
            _time = 0;
            _points[Random.Range(0, _points.Length)].Spawn();
        }
    }
}
