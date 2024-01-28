using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthManager healthManager = GetComponent<HealthManager>(); // Get the HealthManager component

        if (healthManager != null)
        {
            if (collision.CompareTag("Enemy"))
            {
                Destroy(collision.gameObject); // Destroy the enemy GameObject

                healthManager.playerhealth--; // Reduce player health

                if (healthManager.playerhealth <= 0)
                {
                    UnityEngine.SceneManagement.SceneManager.LoadScene(0); // Reload the scene or perform other game over actions
                }
                else
                {
                    StartCoroutine(GetHurt());
                }
            }
        }
    }

    IEnumerator GetHurt()
    {
        Physics2D.IgnoreLayerCollision(7, 8); // Ignore collision temporarily
        yield return null; // No delay
        Physics2D.IgnoreLayerCollision(7, 8, false); // Re-enable collision
    }
}
