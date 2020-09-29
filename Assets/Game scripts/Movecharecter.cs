using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecharecter : MonoBehaviour
{
    public float speed = 04.0f;
    private void Movement()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    public void Update()
    {
        Movement();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      //  Debug.Log("Trigger");
    }
}
