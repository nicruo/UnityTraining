using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameObject floor;
    
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
}
