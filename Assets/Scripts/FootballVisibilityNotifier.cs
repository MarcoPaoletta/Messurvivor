using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballVisibilityNotifier : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
