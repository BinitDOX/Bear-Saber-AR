using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePos : MonoBehaviour
{
    private float x = 0;
    private float z = 0;
    private float n1 = 0;
    private float n2 = 0;
    private float n3 = 0;
    public GameObject efx;
    public GameObject mb;
    public GameObject saber;
    public AudioSource slash;
    private int n;

    void Update()
    {
        Vector3 pos = saber.transform.position;
        Vector3 pos2 = saber.transform.eulerAngles;

        n1 = (pos.y / (Mathf.Tan(pos2.x / 57.3f)));
        n2 = pos.x + (n1 * Mathf.Sin(pos2.y / 57.3f));
        n3 = pos.z + (n1 * Mathf.Cos(pos2.y / 57.3f));

        x = x + (n2 - x);
        z = z + (n3 - z);
    }

    void OnTriggerStay(Collider collider)
    {
        if(collider.tag == "plane" && n >= 6)
        {
            efx.transform.position = new Vector3(x, 0, z);
            //Debug.LogError(x + " " + z);
            Destroy(Instantiate(mb, new Vector3(x, 0.1f, z), Quaternion.identity), 10);
            n = 0;
        }
        if(collider.tag == "cube")
        {
            CubeCut.Cut(collider.transform, transform.position);
            slash.Play();
        }
        n++;
    }

    void OnTriggerExit(Collider collider)
    {
        efx.transform.position = new Vector3(1000, 0, 0);
    }
}
