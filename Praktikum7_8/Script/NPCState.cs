using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCState : MonoBehaviour
{
    GameObject player;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag ("Player");
        anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance (transform.position, player.transform.position) <4f) {
            anim.SetBool ("isDekat",true);
        }else{
            anim.SetBool ("isDekat",false);  
        }
    }
}
