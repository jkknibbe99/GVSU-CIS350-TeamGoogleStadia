using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int maxSpawn;
    float randX;
    Vector2 whereToSpawn;
    public float lowerX;
    public float upperX;
    int numSpawn;
    // Start is called before the first frame update

    //to spawn other enemy types, make a new spawer object, ad give it a different enemy 
    void Start()
    {
        numSpawn = Random.Range(1,maxSpawn);
        for(int i = 0; i < numSpawn; i++){
            randX = Random.Range(lowerX, upperX);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
