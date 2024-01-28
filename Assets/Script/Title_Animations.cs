using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title_Animations : MonoBehaviour
{
    public Transform obj;
    float maxHeight = 0;
    bool playAnimation = false;

    // Start is called before the first frame update
    void Start()
    {
        maxHeight = Screen.height / 1.2f;
        StartCoroutine(SleepTimer());
    }

    IEnumerator SleepTimer()
    {
        yield return new WaitForSeconds(3);
        // Debug.Log("Sleep over");

        playAnimation = true;

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Object location: " + obj.transform.position.y);
        // Debug.Log("Max height: " + maxHeight);
        if(playAnimation == false || obj.transform.position.y >= maxHeight)return;
        Vector3 tempVect = new Vector3(0, 2, 0);

        obj.transform.position += tempVect;
    }
}
