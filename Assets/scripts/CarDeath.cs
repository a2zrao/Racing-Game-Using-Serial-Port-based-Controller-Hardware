using UnityEngine;
using UnityEngine.SceneManagement;

public class CarDeath : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the object that should cause the car to "die"
        if (collision.gameObject.CompareTag("mountain-terrain"))
        {
            // Destroy the car object
            //Destroy(gameObject);

            SceneManager.LoadScene("game_over");



            // You can add any additional logic here, such as showing a game over screen or triggering a restart.
        }
    }


    
}
