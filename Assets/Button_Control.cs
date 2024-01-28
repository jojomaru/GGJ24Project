using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Control : MonoBehaviour
{
    [SerializeField] private string startGame = "Main";

    public void PlayButton()
    {
        SceneManager.LoadScene(startGame);
    }
}
