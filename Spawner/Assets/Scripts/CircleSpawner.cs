using UnityEngine;
using System.Collections;

public class CircleSpawner : MonoBehaviour
{
    [SerializeField] private int _countRepeats;
    [SerializeField] private int _pause;
    [SerializeField] private CircleMovement _circleMovement;
    [SerializeField] private GameObject[] _points;

    private void Start()
    {
        StartCoroutine(MakePause());
    }

    private IEnumerator MakePause()
    {
        for (int i = 0; i < _countRepeats; i++)
        {
            yield return new WaitForSeconds(_pause);

            Spawn(_points[Random.Range(0, _points.Length)]);
        }
    }

    private void Spawn(GameObject point)
    {
        CircleMovement circle = Instantiate(_circleMovement, point.transform.position, Quaternion.identity);

        circle.SetDirection(point.GetComponent<Point>().GetDirection());
    }
}
