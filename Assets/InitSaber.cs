using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitSaber : MonoBehaviour
{
    public AudioSource quiet;
    public AudioSource loud;
    private float x;
    private float y;
    private Vector3 lastPos;
    private float speed;
    //private bool play = false;
    

    void Update()
    {
        Vector3 pos = transform.position;
        //x = pos.x;
        //y = pos.y;
        
        speed = (pos - this.lastPos).magnitude/Time.deltaTime;
        this.lastPos = pos;
       // Debug.LogError(speed);
       /* if (speed > 70f)
            loud.volume = 1f;
        else if (speed > 50f)
            loud.volume = 0.8f; */
        if (speed > 40f)
            loud.volume = Mathf.Lerp(loud.volume, 1f, Time.deltaTime);
        /*    else if (speed > 30f)
                loud.volume = 0.6f;
            else if (speed > 20f)
                loud.volume = 0.5f;
            else if (speed > 10f)
                loud.volume = 0.4f;
            else if (speed > 5f)
                loud.volume = 0.3f;
            else if (speed > 3f)
                loud.volume = 0.2f;
            else if (speed > 1f)
                loud.volume = 0.05f;*/
        else
            loud.volume = Mathf.Lerp(loud.volume, 0f, Time.deltaTime);

    }
}
