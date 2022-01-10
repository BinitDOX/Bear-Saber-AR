using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void onCollisionEnter(Collision coll)
    {
        Debug.LogError("ok1");
        CubeCut.Cut(coll.transform, transform.position);
        
    }

    void onTriggerEnter(Collider coll)
    {
        Debug.LogError("ok2");
        CubeCut.Cut(coll.transform, transform.position);      
    }

    void onTriggerStay(Collider coll)
    {
        Debug.LogError("ok3");
        CubeCut.Cut(coll.transform, transform.position);
    }
}
