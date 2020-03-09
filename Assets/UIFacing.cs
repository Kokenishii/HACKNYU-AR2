using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIFacing : MonoBehaviour
{
    GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if (cam != null)
        {
            Vector3 lookAt = cam.transform.position-transform.position;
            gameObject.transform.LookAt(lookAt);
        }
       
    }
}
