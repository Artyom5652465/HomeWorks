using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;

    public Vector3 GetDirection() => _direction;
}
