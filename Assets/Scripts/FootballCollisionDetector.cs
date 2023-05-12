using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballCollisionDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            return;
        }
            
        Enemy enemyScript = collision.GetComponent<Enemy>();
        enemyScript.lives -= 1;

        if (collision.gameObject.CompareTag("RiverEnemy") || collision.gameObject.CompareTag("BocaEnemy"))
        {
            Destroy(gameObject);
        }

        if (enemyScript.lives <= 0)
        {
            Destroy(collision.gameObject);
        }
    }
}
