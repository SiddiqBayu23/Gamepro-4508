using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;
    Vector3 maju;
    Vector3 mundur;
    public int aksi;

    static Quaternion toQuaternion(Vector3 euler)
    {
    Quaternion q;
    float pitch = euler.y;
    float roll = euler.x;
    float yaw = euler.z;
    float t0 = Mathf.Cos(yaw * 0.5f);
    float t1 = Mathf.Sin(yaw * 0.5f);
    float t2 = Mathf.Cos(roll * 0.5f);
    float t3 = Mathf.Sin(roll * 0.5f);
    float t4 = Mathf.Cos(pitch * 0.5f);
    float t5 = Mathf.Sin(pitch * 0.5f);
    
    Debug.Log (t0 +" "+ t1+" " + t2+" " + t3+" " + t4+" " + t5+"");
    q.x = t0 * t3 * t4 - t1 * t2 * t5;
    q.y = t0 * t2 * t5 + t1 * t3 * t4;
    q.z = t1 * t2 * t4 - t0 * t3 * t5;
    q.w = t0 * t2 * t4 + t1 * t3 * t5;
    return q;
    }
    void Start()
    {
        kekanan = new Vector3(1,0,0);
        kekiri = new Vector3(-1,0,0);
        keatas = new Vector3(0,1,0);
        kebawah = new Vector3(0,-1,0);
        maju = new Vector3(0,0,1);
        mundur = new Vector3(0,0,-1);   
    }

    // Update is called once per frame
    void Update()
    {
        switch (aksi) {
            case 0:
                transform.position = transform.position + (kekanan * 2f * Time.deltaTime);
                break;
            case 1:
                transform.position = transform.position + (kekiri * 2f * Time.deltaTime);
                break;
            case 2:
                transform.position = transform.position + (keatas * 2f * Time.deltaTime);
                break;
            case 3:
                transform.position = transform.position + (kebawah * 2f * Time.deltaTime);;
                break;
            case 4:
                transform.rotation = transform.rotation * toQuaternion(maju * 2f * Time.deltaTime);
                break;
            case 5:
                transform.rotation = transform.rotation * toQuaternion(mundur * 2f * Time.deltaTime);
                break;
        }
    }
}
