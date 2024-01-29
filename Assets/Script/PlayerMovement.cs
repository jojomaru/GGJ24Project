using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Joystick joystick;
    public Transform obj;
    // public int boundriesOffset = 20;
    // private Vector2 screenBounds;
    // private float objectHeight;
    float maxHeight = 0;
    float minHeight = 0;
    float verticalMove = 0f;
    float accelleration = 4f;

    void Start()
    {
        // screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        // objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
        maxHeight = Screen.height / 100;
        minHeight = Screen.height / (-100);
        // Debug.Log("Max Height: " + maxHeight);
        // Debug.Log("Max Height: " + minHeight);

    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 viewPos = transform.position;
        // viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y + objectHeight, screenBounds.y * -1 - objectHeight);
        // viewPos.x = viewPos.x;
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

        transform.position += tempVect;

    }
}

/*
    THIS CODE WAS WRITTEN BY JOSHUA
*/
