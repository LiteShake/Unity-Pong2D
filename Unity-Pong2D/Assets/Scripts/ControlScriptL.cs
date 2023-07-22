using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScriptL : MonoBehaviour
{
    [SerializeField] Camera mainCamera;

    Rigidbody2D playerBody;
    float speed = 22f;

    private void Start()
    {
        
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 accn = Input.acceleration;
        
        playerBody.velocity = new Vector2(0f, -accn.x * speed);   
    }
}
