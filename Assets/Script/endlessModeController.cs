using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endlessModeController : MonoBehaviour
{
    public void endlessMode()
    {
        Debug.Log(GlobalVariable.endlessMode);
        GlobalVariable.endlessMode = true;
        Debug.Log(GlobalVariable.endlessMode);

    }
}
