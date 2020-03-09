using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHigher : MonoBehaviour
{
    public float maxY;
    public float speed;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.position += speed * new Vector3(0, 1, 0) * Time.deltaTime;
    }
}
