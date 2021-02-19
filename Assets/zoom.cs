using UnityEngine;
using System.Collections;

public class zoom : MonoBehaviour
{

    public float acceleration;
    public float maxSpeed;

    private float curSpeed = 0;

    void Update()
    {

        transform.Translate(Vector3.forward * curSpeed);

        curSpeed += acceleration;

        if (curSpeed > maxSpeed)
            curSpeed = maxSpeed;

    }
}


