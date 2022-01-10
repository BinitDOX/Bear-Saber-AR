using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    public AudioSource scro;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "saber")
            scro.Play();
    }

    // Update is called once per frame
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "saber")
            scro.Stop();
    }
}
