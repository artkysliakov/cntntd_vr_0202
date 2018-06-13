using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitOneSecond : MonoBehaviour {

    Rigidbody _rigidbody;
    public float seconds;
    public float massOfObject;

    // Use this for initialization
    void Start () {
        StartCoroutine(MyCoroutine());
    }

    
    IEnumerator MyCoroutine()
    {
        yield return new WaitForSeconds(seconds);

        _rigidbody = gameObject.AddComponent<Rigidbody>(); 
        _rigidbody.mass = massOfObject;
    }
}
