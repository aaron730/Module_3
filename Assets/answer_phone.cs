using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answer_phone : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource ringTone;
    public AudioSource phoneCall;

    private UnityEngine.Vector3 originalPostion;
    private bool hasAnswered = false;

    void Start()
    {
        originalPostion = GameObject.Find("phone2k").transform.position;
        ringTone.loop = true;
        ringTone.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
       var newPostion = GameObject.Find("phone2k").transform.position;
        if(newPostion != originalPostion && hasAnswered == false)
        {
            ringTone.loop = false;
            ringTone.Stop();
            phoneCall.loop = true;
            phoneCall.Play(0);
            hasAnswered = true; 
        }

    }

}

