using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class Sphere : MonoBehaviour
{
    Subject<string> subject = new Subject<string>();

    // Start is called before the first frame update
    void Start()
    {
        subject.Subscribe(msg => Debug.Log("msg1: " + msg));
        subject.OnNext("Good Morning");
        subject.OnNext("Hello");

        subject.Subscribe(msg => Debug.Log("msg2: " + msg));
        subject.Subscribe(msg => Debug.Log("msg3: " + msg));
        subject.OnNext("Good Evening");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
