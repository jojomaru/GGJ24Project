using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Joystick joystick;
    public Transform obj;
    float maxHeight = 0;
    float minHeight = 0;
    float verticalMove = 0f;
    float accelleration = 4f;

    void Start()
    {
        maxHeight = Screen.height / 100;
        minHeight = Screen.height / (-100);
        // Debug.Log("Max Height: " + maxHeight);
        // Debug.Log("Max Height: " + minHeight);

    }

    // Update is called once per frame
    void Update()
    {
        verticalMove = joystick.Vertical * accelleration;
        float playerYPosition = obj.transform.position.y;

        // Debug.Log("Player Y Position: " + playerYPosition);

        // Debug.Log(verticalMove);

        if((playerYPosition >= maxHeight && verticalMove > 0) || (playerYPosition <= minHeight && verticalMove < 0) ){
            Debug.Log("Screen border reached.");
            return;
        }

        Vector3 tempVect = new Vector3(0, verticalMove, 0);

        tempVect = tempVect.normalized * accelleration * Time.deltaTime;

        obj.transform.position += tempVect;

    }
}

/*
    THIS CODE WAS WRITTEN BY JOSHUA
*/
