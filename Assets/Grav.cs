using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grav : MonoBehaviour
{
    Rigidbody rb;
    //public AudioSource slash;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //slash = GetComponent<AudioSource>();
        //chop = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempVect = new Vector3(30, 0, 0);
        tempVect = tempVect.normalized * 400f * Time.deltaTime;
        //tempVect = tempVect.normalized * 500f * Time.deltaTime;
        rb.MovePosition(transform.position + tempVect);
        if (transform.position.x > 60f) 
            Destroy(gameObject);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "saber")
        {
            //slash.Play();
            rb.useGravity = true;           
            //CubeCut.Cut(transform, col.transform.position);
        }

    }
}
