using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonReturnMainMenu : MonoBehaviour
{
    [SerializeField] private string mainMenu = "Main menu";

    public void settingsButton()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
