using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody playerRb;
    public float fuelPower;

    public int health = 3;

    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene("Main");
        }

        if(Input.GetKey(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * fuelPower * Time.deltaTime, ForceMode.Impulse);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }

        Debug.Log(Time.deltaTime);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(new Vector3(horizontalInput * Time.deltaTime * moveSpeed, 0, verticalInput * Time.deltaTime * moveSpeed));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            health--;
        }
    }
}
