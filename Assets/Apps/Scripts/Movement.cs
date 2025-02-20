using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField, Range(5f, 20f)] private float speed;

    private Rigidbody2D rb2d;
    private Vector2 direction;
    public InputActionReference move;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if (rb2d is null)
        {
            gameObject.AddComponent<Rigidbody2D>();
        }
    }

    private void Update()
    {
        direction = move.action.ReadValue<Vector2>();
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        Vector2 velocity = rb2d.velocity;
        velocity.x = direction.x * speed;
        rb2d.velocity = velocity;
    }
}
