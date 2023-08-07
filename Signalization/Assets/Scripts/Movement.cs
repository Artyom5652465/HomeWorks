using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _positionInHouseY;
    [SerializeField] private float _positionOutsideY;
    [SerializeField] private int _duration;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMoveY(_positionInHouseY, _duration));
        sequence.Append(transform.DOMoveY(_positionOutsideY, _duration));
    }
}