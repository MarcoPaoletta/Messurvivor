using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    [SerializeField] private PlayerCoillisionDetector playerCoillisionDetectorScript;

    [SerializeField] private GameObject star2;
    [SerializeField] private GameObject star3;
    private void Update()
    {
        if(playerCoillisionDetectorScript.lives == 2)
        {
            Destroy(star3);
        }

        if(playerCoillisionDetectorScript.lives == 1)
        {
            Destroy(star2);
        }   
    }
}
