using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;  //variable is used by computer to understand that the left and right arrow keys have been pressed
    public float speed = 20.0f;  //variable is used as speed Player will move accross screen when arrows are used
    public float xRange = 15.0f;  //variable controls the range player is limited to accross screen
    public float zRange = 7.0f;  //controls the range player is limited to accross the screen

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Move player using arrow input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        ConstraintPlayer();
        Fish();

    }

    // Constraint player's movement on x-axis
    void ConstraintPlayer()
    {
        //keep player within left boundary
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        //keep player within right boundary
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    // When space is pressed, player moves along z-axis, like a fishing hook, just straight down
    void Fish()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //keeps player within bottom boundary
            if (transform.position.z < -zRange)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
            }
            //moves player down when space is pressed
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        else transform.position = new Vector3(transform.position.x, transform.position.y, 6);
    }
}
