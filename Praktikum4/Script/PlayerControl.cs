using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public Vector2 jumpForce = new Vector2(0,300);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown ("space")) {
            GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
            GetComponent<Rigidbody2D> ().AddForce(jumpForce);
        }
        Vector2 screenPosition = 
        Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
            Die();
    }
    void Die(){
        Debug.Log("GAME OVER");
        SceneManager.LoadScene("SampleScene");
    }
    void OnCollisionEnter2d(Collision2D coll){
        Die();
    }
}
