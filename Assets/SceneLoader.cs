using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private HealthManager healthManager; // Reference to the HealthManager component

    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>(); // Get the HealthManager component in the scene
        if (healthManager == null)
        {
            Debug.LogError("HealthManager component not found in the scene.");
        }

        // Reset player health when the scene starts
        if (healthManager != null)
        {
            HealthManager.playerhealth = 3; // Use the class name to access the static variable
        }
    }

    public void LoadScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
