using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidPlay : MonoBehaviour
{
    public UnityEngine.Video.VideoPlayer vp;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(vid());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator vid()
    {
        yield return new WaitForSeconds(20f);
        vp.Play();
    }
}
