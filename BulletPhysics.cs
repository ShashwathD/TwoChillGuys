using UnityEngine;

public class BulletPhysics : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.linearVelocity = transform.right * speed;    
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Destroy(gameObject);
    }
}
