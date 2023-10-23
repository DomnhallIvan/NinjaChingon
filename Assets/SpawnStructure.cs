using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStructure : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnPosition;
    public float spawnTimer = 1.0f;
    public float timer = 0.0f;


    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime;
        if (timer >= spawnTimer) 
        {
            Instantiate(prefab, spawnPosition);
            timer = 0;
        }
       
    }


}
