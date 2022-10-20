using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    //movement speed in units per second
    private float movementSpeed = 5f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");
        //update the position
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);
        //output to log the position change
        // Debug.Log(transform.position);
        //     if (Input.GetKey(KeyCode.W))
        //     {
        //         transform.Translate(0, moviespreed*Time.deltaTime, 0);
        //     }
        //     else if (Input.GetKey(KeyCode.A))
        //     {
        //           transform.Translate(-moviespreed*Time.deltaTime, 0, 0);
        //     }
        //     else if (Input.GetKey(KeyCode.S))
        //     {
        //         transform.Translate(0, -moviespreed*Time.deltaTime, 0);
        //     }
        //     else if (Input.GetKey(KeyCode.D))
        //     {
        //        transform.Translate(moviespreed*Time.deltaTime, 0, 0);
        //     }
        // }
        if(Input.GetKey(KeyCode.Escape)){
            transform.localPosition = new Vector3(-3.7192f ,0.653f ,0);
            ResumeGame ();
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor1")
        {
            Debug.Log("black");
        }
        else if (other.gameObject.tag == "Floor2")
        {
            Debug.Log("orange");
        }
        else if(other.gameObject.tag == "deadline"){
            Debug.Log("dead");
        }
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "deadline"){
            transform.position = transform.position;
            Debug.Log("dead");
            PauseGame();
        }
    }
    void PauseGame ()
    {
        Time.timeScale = 0;
    }
    void ResumeGame ()
    {
        Time.timeScale = 1;
    }
}