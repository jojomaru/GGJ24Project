using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public static int playerhealth = 3;
    public GameObject[] hearts; // Change to GameObject array instead of Image array
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Start(){
        playerhealth = 3;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerhealth)
            {
                hearts[i].GetComponent<Image>().sprite = fullHeart; // Set sprite to full heart
                hearts[i].SetActive(true); // Enable heart GameObject
            }
            else
            {
                hearts[i].SetActive(false); // Disable heart GameObject
            }
        }
    }
}
