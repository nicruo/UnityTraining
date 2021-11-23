using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody playerRb;
    public float fuelPower;

    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * fuelPower * Time.deltaTime, ForceMode.Impulse);
            playerRb.AddTorque(Vector3.forward * 10000);
        }

        Debug.Log(Time.deltaTime);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 newPosition = gameObject.transform.position + new Vector3(horizontalInput*Time.deltaTime * moveSpeed, 0, verticalInput * Time.deltaTime * moveSpeed);
        gameObject.transform.position = newPosition;
    }
}
