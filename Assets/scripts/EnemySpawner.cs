using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    float Randx;
    float Randy;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextspawn = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time > nextspawn)
        {
            nextspawn = Time.time + spawnRate;
            Randx = Random.Range(-8.4f, 0f);
            Randy = Random.Range(5.0f, -5.0f);
            whereToSpawn = new Vector2(Randx, Randy);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
	}
}
