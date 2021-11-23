using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject entity;

    public float xSpan = 4.0f;
    public float zSpan = 4.0f;
    public float spawnRate = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEntity", 1.0f, spawnRate);
    }

    void SpawnEntity()
    {
        Instantiate(entity, gameObject.transform.position + new Vector3(Random.Range(-xSpan, xSpan) ,0, Random.Range(-zSpan, zSpan)), entity.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
