using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace movementSpace{
public class movement : MonoBehaviour
{
     float moveSpeed = 10f;
     public Rigidbody2D rb;
     public int score;
     Vector2 movementH; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update(){
    // Update is called once per frame
     movementH.x = Input.GetAxisRaw("Horizontal");
      }  
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "food"){
        score++;
        Debug.Log(score);
        Destroy(collision.gameObject);
        }
    }      
   void FixedUpdate(){
            rb.MovePosition(rb.position + movementH * moveSpeed * Time.fixedDeltaTime);
                   
          }
    }  
}


