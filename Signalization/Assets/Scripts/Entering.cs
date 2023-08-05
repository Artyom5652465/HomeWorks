using UnityEngine;
using UnityEngine.Events;

public class Entering : MonoBehaviour
{
    [SerializeField] private UnityEvent _event;
    public bool IsEntered { get; private set; }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Player player))
        {
            IsEntered = !IsEntered;
            _event.Invoke();
        }
    }
}
