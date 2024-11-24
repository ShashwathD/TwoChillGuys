using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditDamage : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth;

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "Player 1"){
            playerHealth.TakeDamagePlayer(damage);
        }
    }
}
