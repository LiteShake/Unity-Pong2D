using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    private Vector3 direction = new Vector3(0, 0, 0);
    private float speed = 6f;
    private bool firstMoveDone = false ;
   
    public int playerPoints = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3( -8.78f, 0 ,0);
        direction = new Vector3(0, 0, 0);
        firstMoveDone = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !firstMoveDone)
        {
            // Debug.Log("Space!");
            direction = new Vector3( 1.732f , 1, 0 );
            firstMoveDone = true;
            
        }

        transform.position += speed * direction * Time.deltaTime ;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log("Collide !");
        if (collision.gameObject.CompareTag("Bouncers"))
        {

            direction = new Vector3(direction.x, -(direction.y), 0);
        }

        if (collision.gameObject.CompareTag("Players"))
        {

            direction = new Vector3(-(direction.x + Random.Range(-1.1f, 1.1f)), direction.y, 0);

            if (collision.gameObject.name == "PlayerL")
            {
                playerPoints++;
                
            }

        }

        if ( collision.gameObject.CompareTag("Death"))
        {
            Start();
        }
    }
}
