using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSlideInAnimation : MonoBehaviour
{
    public Transform obj;
    bool playAnimation = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SleepTimer());
        StartCoroutine(DisableTimer());

    }

    IEnumerator SleepTimer()
    {
        yield return new WaitForSeconds(3.5f);
        // Debug.Log("Sleep over");

        playAnimation = true;

    }

    IEnumerator DisableTimer()
    {
        yield return new WaitForSeconds(4.25f);
        // Debug.Log("Sleep over");

        playAnimation = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(playAnimation == false)return;
        Vector3 tempVect = new Vector3(0, 1, 0);

        obj.transform.position += tempVect;
    }
}
