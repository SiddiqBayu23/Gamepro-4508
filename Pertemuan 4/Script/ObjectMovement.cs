using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;
    Vector3 maju;
    Vector3 mundur;

    public int aksi;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3 (1,0,0);
        kekiri = new Vector3 (-1,0,0);
        keatas = new Vector3 (0,1,0);
        kebawah = new Vector3 (0,-1,0);
        maju = new Vector3(0,0,1);
        mundur = new Vector3(0,0,-1);

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right"))
        transform.position = transform.position + (kekanan * 3 * Time.deltaTime);
        if(Input.GetKey("left"))
        transform.position = transform.position + (kekiri * 3 * Time.deltaTime);
        if(Input.GetKey("down"))
        transform.position = transform.position + (kebawah * 3 * Time.deltaTime);
        if(Input.GetKey("up"))
        transform.position = transform.position + (keatas * 3 * Time.deltaTime);
        if(Input.GetKey(KeyCode.W))
        transform.position = transform.position + (maju * 3 * Time.deltaTime);
        if(Input.GetKey(KeyCode.S))
        transform.position = transform.position + (mundur * 3 * Time.deltaTime);

        if(Input.GetKey(KeyCode.D))
        transform.rotation = transform.rotation * toQuaternion(keatas * 10 * Time.deltaTime);
        if(Input.GetKey(KeyCode.A))
        transform.rotation = transform.rotation * toQuaternion(kebawah * 10 * Time.deltaTime);
        

  
        
    }
    static Quaternion toQuaternion(Vector3 euler){
        Quaternion q;
        float pitch = euler.y;
        float roll = euler.x;
        float yaw = euler.z;
        float t0 = Mathf.Cos(yaw * 0.05f);
        float t1 = Mathf.Sin(yaw * 0.05f);
        float t2 = Mathf.Cos(roll * 0.05f);
        float t3 = Mathf.Sin(roll * 0.05f);
        float t4 = Mathf.Cos(pitch * 0.05f);
        float t5 = Mathf.Sin(pitch * 0.05f);
        Debug.Log (t0+" "+t1+" "+t2+" "+t3+" "+t4+" "+t5+" ");

        q.x = t0 * t3 * t4 - t1 * t2 * t5;
        q.y = t0 * t2 * t5 + t1 * t3 * t4;
        q.z = t1 * t2 * t4 - t0 * t3 * t5;
        q.w = t0 * t2 * t4 + t1 * t3 * t5;
        return q; 
    } 
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "enemyTag"){
            Debug.Log ("Game Over");
            Time.timeScale = 0;
        }
        if(coll.gameObject.tag == "coinTag"){
            Debug.Log ("Score anda : "+ score);
            score = score + 1;
            
        }
    }
    void OnCollisionStay2D(Collision2D coll){
        if(coll.gameObject.tag == "playerTag"){
            Debug.Log ("Sedang Nabrak");
        }

    }
    void OnCollisionExit2D(Collision2D coll) {
        if(coll.gameObject.tag == "enemyTag"){
            Debug.Log ("Sudah Nabrak");
        }
    }
}