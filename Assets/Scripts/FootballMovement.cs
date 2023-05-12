using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    private void Start()
    { 
        Vector2 playerMoveInput = GameObject.FindObjectOfType<PlayerMovement>().moveInput;
        rb.velocity = playerMoveInput * 20; 
    }
}
