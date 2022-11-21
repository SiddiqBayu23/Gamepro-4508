using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cobajalan : MonoBehaviour
{
    public float movespeed;
    int status;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + movespeed, transform.position.y);
    }
}
