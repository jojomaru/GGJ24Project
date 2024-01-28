using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControlSettings : MonoBehaviour
{
    [SerializeField] private string settingsMenu = "Settings";

    public void settingsButton()
    {
        SceneManager.LoadScene(settingsMenu);
    }
}
