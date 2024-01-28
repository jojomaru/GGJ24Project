using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private HealthManager healthManager; // Reference to the HealthManager component

    void Start()
    {
        healthManager = GetComponent<HealthManager>(); // Get the HealthManager component attached to this GameObject
        if (healthManager == null)
        {
            Debug.LogError("HealthManager component not found on the GameObject.");
        }

        // Reset player health when the scene starts
        if (healthManager != null)
        {
            healthManager.playerhealth = 3;
        }
    }

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
