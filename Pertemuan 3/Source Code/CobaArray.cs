using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CobaArray : MonoBehaviour
{
    public string[] items;
    //Use this for initialization
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < items.Length; i++)
            Debug.Log (items[i]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
