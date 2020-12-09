using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    private Transform playerPos;
    public int movespeedEnemy = 5;
    private Rigidbody2D rb;
    private Vector2 movement;
    private int analysisD;
    



    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = playerPos.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
       // Debug.Log("This"+ analysisD);

    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player")
        {
            analysisD++;
            Debug.Log("D"+analysisD);
            Destroy(gameObject);
        }
        else
            Debug.Log("Stop");
    }
    
    
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * movespeedEnemy * Time.deltaTime));
    }

}
