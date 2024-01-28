using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    public Transform obj;
    bool playAnimation = false;
    float endYPosition = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SleepTimer());
        endYPosition = obj.transform.position.y - 90;
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
        if(playAnimation == false || obj.transform.position.y <= endYPosition)return;
        Vector3 tempVect = new Vector3(0, -1, 0);

        obj.transform.position += tempVect;
    }
}
