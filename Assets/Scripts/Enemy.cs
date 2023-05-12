using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    public int lives;

    private Transform playerTransform;

    private void Update()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 direction = playerTransform.position - transform.position;
        Vector3 velocity = direction.normalized * speed;
        transform.Translate(velocity * Time.deltaTime);
    }
}
