using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;
    public Rigidbody2D rigidbody2D;
    public Animator animator;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // FixedUpdate is called 50 times per second, making it ideal for physics-based movement
    void FixedUpdate()
    {
        Vector2 moveInput = Vector2.zero;

        moveInput = new Vector2(
                (Keyboard.current.dKey.isPressed ? 1 : 0) - (Keyboard.current.aKey.isPressed ? 1 : 0),
                (Keyboard.current.wKey.isPressed ? 1 : 0) - (Keyboard.current.sKey.isPressed ? 1 : 0)
            );

        animator.SetFloat("horizontal", Mathf.Abs(moveInput.x));
        animator.SetFloat("vertical", Mathf.Abs(moveInput.y));

        // Flip the character's sprite based on the horizontal movement direction
        if (moveInput.x > 0)
        {
            // Patrz w prawo (skala X = 1)
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (moveInput.x < 0)
        {
            // Patrz w lewo (skala X = -1)
            transform.localScale = new Vector3(-1, 1, 1);
        }

        // Set players movement
        rigidbody2D.linearVelocity = moveInput * speed;
    }
}
