using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingWater : MonoBehaviour
{
    Vector3 position;
    public float risespeed = 0.5f;
    public float heightlimit = 25f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position = new Vector3(transform.position.x, transform.position.y + (Time.deltaTime * risespeed), transform.position.z);
        //transform.position = position;
        if (transform.position.y < heightlimit)
        {
            this.transform.Translate(0, risespeed, 0);
        }  
    }
}
