using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject entity;

    public float transformDelta = 1.1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEntity", 1.0f, 2.0f);
    }

    void SpawnEntity()
    {
        Instantiate(entity, gameObject.transform.position * Random.Range(1.0f, transformDelta), entity.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
