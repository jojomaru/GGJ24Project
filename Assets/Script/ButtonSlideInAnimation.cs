using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSlideInAnimation : MonoBehaviour
{
    public Transform obj;
    bool playAnimation = false;
    float endYPosition = 0;

    // Start is called before the first frame update
    void Start()
    {
        endYPosition = obj.transform.position.y + 200;
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
        Vector3 tempVect = new Vector3(0, 3, 0);

        obj.transform.position += tempVect;
    }
}
