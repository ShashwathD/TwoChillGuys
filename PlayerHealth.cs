using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamagePlayer(int damageplayer){
        health -= damageplayer;
        if(health <= 0){
            Destroy(gameObject);
        }
    }

}
