using UnityEngine;
using System.Collections;

public class zoom : MonoBehaviour
{

    public float acceleration;
    public float maxSpeed;
    public int secondsUntilDeceleration;
    private bool faster = true;
    private float curSpeed = 0;


    private void Start()
    {
        StartCoroutine(passiveMe());
    }

    void Update()
    {
        //Debug.LogError(curSpeed);
        if (faster == true)
        {

            transform.Translate(Vector3.forward * curSpeed);

            curSpeed += acceleration;

            if (curSpeed > maxSpeed)
                curSpeed = maxSpeed;
        }
        else
        {
            transform.Translate(Vector3.forward * curSpeed);

            curSpeed -= acceleration;

            if (curSpeed <= 0)
                curSpeed = 0;
        }

    }

    IEnumerator passiveMe()
    {
        yield return new WaitForSeconds(secondsUntilDeceleration);
        Debug.Log("activated");
        faster = false;
    }


}


