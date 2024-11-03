using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    public float horizontalAmplitude = 0.5f;
    public float horizontalFrequency = 2f;

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        float horizontalOffset = Mathf.Sin(Time.time * horizontalFrequency) * horizontalAmplitude;
        transform.Translate(Vector3.right * horizontalOffset * Time.deltaTime);
    }
}
