using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameObject floor;
    public float destroyTime = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        floor = GameObject.Find("Floor");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < floor.transform.position.y)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Floor"))
        {
            Destroy(gameObject, destroyTime);
        }
    }

}
