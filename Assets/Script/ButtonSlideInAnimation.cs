using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSlideInAnimation : MonoBehaviour
{
    public Transform obj;
    public int maxHeightOffset = 250;
    bool playAnimation = false;
    float endYPosition = 0;

    // Start is called before the first frame update
    void Start()
    {
        endYPosition = (Screen.height / 2) + obj.transform.position.y;
        StartCoroutine(SleepTimer());

    }

    IEnumerator SleepTimer()
    {
        yield return new WaitForSeconds(3.5f);
        // Debug.Log("Sleep over");

        playAnimation = true;

    }

    // Update is called once per frame
    void Update()
    {
        if(playAnimation == false || obj.transform.position.y >= endYPosition)return;

        float moveLength = 500 * Time.deltaTime;

        Vector3 tempVect = new Vector3(0, moveLength, 0);

        obj.transform.position += tempVect;
    }
}
