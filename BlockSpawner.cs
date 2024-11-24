using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject stationaryBlock; // The object to spawn at the specified position
    public GameObject fallingBlock; // The object to spawn as a falling block
    public int maxUses = 3; // Maximum number of times the spawner can be used
    private int currentUses = 0; // Tracks how many times the spawner has been used
    public float spawnDistance = 5f; // Horizontal distance from the spawner
    public float spawnHeight = 10f; // Height above the spawner to spawn the falling block
    public float fallingOffsetX = 1f; // Horizontal offset for the falling blocks
    public float fallingBlockSpacing = 2f; // Horizontal offset between each falling block

    void Update()
    {
        // Check if the spawn key is pressed and max uses is not exceeded
        if (Input.GetKeyDown(KeyCode.V) && currentUses < maxUses)
        {
            // Calculate the position for the stationary block
            Vector3 stationaryPosition = (Vector2)transform.position 
                                         + (Vector2.right * spawnDistance * transform.localScale.x);

            // Spawn the stationary block
            Instantiate(stationaryBlock, stationaryPosition, Quaternion.identity);

            // Spawn multiple falling blocks horizontally, spaced apart
            for (int i = 0; i < 3; i++) // Change '3' to however many falling blocks you want
            {
                // Calculate the horizontal offset for each falling block
                Vector3 fallingPosition = transform.position + Vector3.up * spawnHeight
                                          + Vector3.right * (fallingOffsetX + i * fallingBlockSpacing);

                // Spawn the falling block at the calculated position
                Instantiate(fallingBlock, fallingPosition, Quaternion.identity);
            }

            // Increment the use counter
            currentUses++;
        }
    }
}
