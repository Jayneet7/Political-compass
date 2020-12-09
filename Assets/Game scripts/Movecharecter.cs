using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movecharecter : MonoBehaviour
{
    public float speed = 4.0f;
    public Rigidbody2D rbplayer;
    public Animator animator;


    public Camera cam;
    public bool destroy = false;
    Vector2 movement;
    public float myanim;



    /*private void Movement()
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
    }*/

    public void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        myanim = (movement.x + movement.y);
        animator.SetFloat("speed", Mathf.Abs(myanim));

        if (Input.GetMouseButton(0))
            animator.SetBool("attack", true);

        else if (Input.GetMouseButton(1))
            animator.SetBool("attack", false);


        //Movement();
    }



    void FixedUpdate() 

    {
        movement.Normalize();


        rbplayer.MovePosition(rbplayer.position + movement * speed * Time.fixedDeltaTime);

        Vector3 mousepos = Input.mousePosition;
        Vector3 scrrenpoint = cam.WorldToScreenPoint(transform.localPosition);

        Vector2 offset = new Vector2(mousepos.x - scrrenpoint.x, mousepos.y - scrrenpoint.y);

        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        
    }

   

    /* private void OnTriggerEnter2D(Collider2D collision)
     {

       //  Debug.Log("Trigger");
     }*/


}
