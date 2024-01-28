using System.Collections;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public HealthManager healthManager; // Reference to the HealthManager component in the Unity Editor

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (HealthManager.playerhealth > 0) // Access the static variable directly through the type name
        {
            if (collision.CompareTag("Enemy"))
            {
                Destroy(collision.gameObject); // Destroy the enemy GameObject

                HealthManager.playerhealth--; // Reduce player health

                if (HealthManager.playerhealth <= 0)
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
