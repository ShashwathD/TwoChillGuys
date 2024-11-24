using UnityEngine;

public class FallingBlock : MonoBehaviour
{
    public int damageAmount = 1; // The amount of damage the falling block deals

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the falling block has collided with the player
        if (other.gameObject.CompareTag("Player 1"))
        {
            // Get the PlayerHealth component from the player object
            PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();

            // If the PlayerHealth script is found, apply damage
            if (playerHealth != null)
            {
                playerHealth.TakeDamagePlayer(damageAmount);
            }

            // Destroy the falling block after collision
            Destroy(gameObject);
        }
    }
}
