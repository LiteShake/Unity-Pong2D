using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppoScript : MonoBehaviour
{
    [SerializeField] GameObject ball;

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(ball.transform.position.y) <= 4.2)
            transform.position = new Vector3( transform.position.x, ball.transform.position.y, transform.position.z );   
    }
}
