using UnityEngine;
using UnityEngine.Tilemaps;

public class DestroyMap : MonoBehaviour
{
    public Tilemap tilemap; // Reference to the Tilemap
    public TileBase destroyedTile; // The tile to replace the destroyed tile with (optional)

    private void Awake()
    {
        // If the Tilemap reference isn't set, get it from the current object
        if (tilemap == null)
        {
            tilemap = GetComponent<Tilemap>();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object that collided is a projectile (bullet)
        if (other.CompareTag("Bullet")) // Ensure your bullet has the "Bullet" tag
        {
            // Get the collision point (where the bullet hit)
            Vector3 hitPoint = other.transform.position;

            // Convert the hit point to Tilemap coordinates
            Vector3Int tilePosition = tilemap.WorldToCell(hitPoint);

            // Get the tile at the position of the hit
            TileBase tileAtPosition = tilemap.GetTile(tilePosition);

            if (tileAtPosition != null)
            {
                // Replace the tile with a "destroyed" tile (or null to remove it)
                tilemap.SetTile(tilePosition, destroyedTile); // Use destroyedTile or set to null to remove it
                Debug.Log("Tile destroyed at: " + tilePosition);
            }

            // Optionally, destroy the bullet after it hits the Tilemap
            Destroy(other.gameObject);
        }
    }
}
