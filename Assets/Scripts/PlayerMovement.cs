using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    private float speed = 9f;
    private float moveX;
    private float moveY;
    public Vector2 moveInput;

    private void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        moveInput = new Vector2(moveX, moveY).normalized;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8.6f, 8.6f), Mathf.Clamp(transform.position.y, -4.6f, 4.6f), transform.position.z
);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * speed * Time.fixedDeltaTime);
    }
}
