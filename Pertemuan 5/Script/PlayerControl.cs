using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float hinput;
    float vinput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hinput = Input.GetAxis("Horizontal");
        vinput = Input.GetAxis("Vertical");

       if(Input.GetKey(KeyCode.Space)){

       
       transform.Translate(Vector3.forward * 1 * Time.deltaTime);
       transform.Rotate(0,hinput * 100 * Time.deltaTime, 0);
       }
    }
}