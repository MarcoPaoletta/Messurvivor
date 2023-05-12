using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballKick : MonoBehaviour
{
    [SerializeField] private GameObject footballPrefab;
    [SerializeField] private PlayerMovement playerMovementScript;
    private void Update()
    {   
        if(Input.GetKeyDown(KeyCode.Space) && playerMovementScript.moveInput != Vector2.zero)
        {
            Instantiate(footballPrefab, transform.position, Quaternion.identity);
        }
    }
}
