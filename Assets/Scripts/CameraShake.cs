using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Intensity of the screen shake
    public float shakeIntensity = 0.05f;

    // Duration of the screen shake
    public float shakeDuration = 0.25f;

    // The transform of the camera to shake
    public Transform cameraTransform;

    // The original position of the camera
    private Vector3 originalPosition;

    private void Start()
    {
        // Store the original position of the camera
        originalPosition = cameraTransform.localPosition;
    }

    // Call this method to start the screen shake effect
    public void ShakeScreen()
    {
        StartCoroutine(ShakeCoroutine());
    }

    private IEnumerator ShakeCoroutine()
    {
        // Set the start time and end time for the screen shake effect
        float startTime = Time.time;
        float endTime = startTime + shakeDuration;

        while (Time.time < endTime)
        {
            // Calculate the random offset for the camera position
            Vector3 offset = Random.insideUnitSphere * shakeIntensity;

            // Apply the offset to the camera position
            cameraTransform.localPosition = originalPosition + offset;

            // Wait for the next frame
            yield return null;
        }

        // Reset the camera position to its original position
        cameraTransform.localPosition = originalPosition;
    }
}
