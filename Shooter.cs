using UnityEngine;
using System.Collections; // Add this line

public class Shooter : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public PlayerHealth playerHealth;
    public int damageAmount = 15;
    public float damageDelay = 0.5f; // Delay between damage applications (in seconds)

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();

            if (playerHealth != null)
            {
                StartCoroutine(ApplyDamageWithDelay());
            }
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    // Coroutine to apply damage with a delay
    IEnumerator ApplyDamageWithDelay()
    {
        for (int i = 0; i < 10; i++)
        {
            playerHealth.TakeDamagePlayer(damageAmount);
            yield return new WaitForSeconds(damageDelay); // Wait for the specified delay before applying next damage
        }
    }
}
