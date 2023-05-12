using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCoillisionDetector : MonoBehaviour
{
    [SerializeField] private CameraShake cameraShakeScript;

    public int lives = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.Contains("Enemy"))
        {
            cameraShakeScript.ShakeScreen();
            lives -= 1;

            if(lives <= 0)
            {
                SceneManager.LoadScene("Menu");
            }

            Destroy(collision.gameObject);
        }
    }
}
