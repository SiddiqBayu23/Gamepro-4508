using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    Vector3 kebawah;
    void Start()
    {
        kebawah = new Vector3(0,-1,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (kebawah * speed * Time.deltaTime);
    }
   

}
