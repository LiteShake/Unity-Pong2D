using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScriptL : MonoBehaviour
{
    [SerializeField] Camera mainCamera;

    // Update is called once per frame
    void Update()
    {
        float move_y = mainCamera.ScreenToWorldPoint(Input.mousePosition).y ;

        // float move_y = Input.mousePosition.y;
        // Debug.Log(move_y);

        Vector2 trans = transform.position;
        trans.y = move_y;

        if( Mathf.Abs(trans.y) <= 4.2 )
            transform.position = trans;
    }
}
