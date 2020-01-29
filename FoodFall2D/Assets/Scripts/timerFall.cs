using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerFall : MonoBehaviour
{
    public Transform player;
    public int score = 0;
    public float maxDistance = 5f;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
         rigidbody = GetComponent<Rigidbody2D>();
       //  rigidbody.useGravity = false;        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance (player.position, transform.position) < maxDistance) { //transform is the object that this script is attached to
         //    rigidbody.useGravity = true;
      }
     }
}

