using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth;

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player"){
            playerHealth.TakeDamagePlayer(damage);
        }
    }
}
