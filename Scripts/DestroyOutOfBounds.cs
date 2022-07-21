using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float leftBound = -20.0f;
    private float rightBound = 20.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //destroys objects when they're out of bounds
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }
}
