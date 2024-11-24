using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target1;
    public Transform target2; 

    void Update()
    {
        float middleX = (target1.position.x + target2.position.x) / 2;
        float middleY = (target1.position.y + target2.position.y) / 2;

        transform.position = new Vector3(middleX, middleY, transform.position.z);
    }
}
