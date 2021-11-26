using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody playerRb;
    public float fuelPower;
    private GameObject floor;
    public int health = 3;

    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
        floor = GameObject.Find("Floor");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < floor.transform.position.y)
        {
            KillPlayer();
        }

        if (health <= 0)
        {
            KillPlayer();
        }

        if(Input.GetKey(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * fuelPower * Time.deltaTime, ForceMode.Impulse);
        }

        Debug.Log(Time.deltaTime);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(new Vector3(horizontalInput * Time.deltaTime * moveSpeed, 0, verticalInput * Time.deltaTime * moveSpeed));
    }

    void KillPlayer()
    {
        SceneManager.LoadScene(GameManager.MenuScene);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            health--;
        }
    }
}
