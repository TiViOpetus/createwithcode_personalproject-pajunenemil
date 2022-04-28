using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public CharacterController controller;
    
    public float speed = 5f;

    Rigidbody rb;


    private void Start()
    {
        
    }


    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        //rb.velocity = new Vector3(x, rb.velocity.y, z) * speed;

    }

}


