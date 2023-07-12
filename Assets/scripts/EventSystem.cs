using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;


public class EventSystem : MonoBehaviour
{
    public string sceneName; // The name of the scene to load

    public void LoadScene()
    {
        SceneManager.LoadScene("race");

    }
    public void LoadHOME()
    {
        SceneManager.LoadScene("HOME");
    }
    public void QUIT()
    {
        //UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit();
    }

    private void death(Collision collision)
    {
        // Check if the collision is with the object that should cause the car to "die"
        if (collision.gameObject.CompareTag("mountain-terrain"))
        {
            // Destroy the car object
            Destroy(gameObject);
            SceneManager.LoadScene("game_over");

            
        }
    }
}

