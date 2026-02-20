using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    // [1] declare a private float variable to store the top bound
    private float topBound = 30;
    private float lowerBound = -10;
    private float rightBound = 25;
    private float leftBound = -25;

    // Update is called once per frame
    void Update()
    {
        // [2] if the object goes out of the top bound
        if (transform.position.z > topBound)
        {
            // [3] destroy the object
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

    }
}
