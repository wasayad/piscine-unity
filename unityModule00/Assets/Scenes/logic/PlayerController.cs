using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PL : MonoBehaviour
{
    private float speed = 2f;
    private Rigidbody rb;
    private bool canJump;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        canJump = true;
    }
    void OnCollisionStay(Collision collisionInfo)
    {
        canJump = true;
    }
    void OnCollisionExit(Collision collisionInfo)
    {
        canJump = false;
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.CompareTag("Floor")) {
            Debug.Log("GameOver");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown("space") && canJump)
        {
           rb.velocity += Vector3.up * 5f;
        }
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity += Vector3.back * Time.deltaTime * speed;
        }
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity += Vector3.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity += Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity += Vector3.left * Time.deltaTime * speed;
        }
    }
}
