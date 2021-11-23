using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour
{
    public float scaleFactor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Reduce scale on collision
        if (collision.gameObject.CompareTag("Ball"))
        {
            gameObject.transform.localScale *= scaleFactor;
        }
    }
}
