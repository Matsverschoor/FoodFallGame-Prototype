using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnFood : MonoBehaviour
{
    public GameObject foodPrefab;
    
    public float spawnTime = 3f;
    
    public GameObject[] food;
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
      //  Instantiate(foodPrefab);
      
    }

    void Spawn(){
      int spawnPointX = Random.Range (-13, 1);
     // int spawnPointZ = Random.Range (-360, 350);
      Vector3 spawnPosition = new Vector3 (spawnPointX, 1);
      Instantiate(food[Random.Range(0, food.Length)], spawnPosition, Quaternion.identity);
    }
   
}
