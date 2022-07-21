using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public ParticleSystem actionParticle;  //particle to play when player collides with object
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Overrided OnTriggerEnter method
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Fish"))
        {
            actionParticle.Play();
            Destroy(gameObject);

        }
        else if (gameObject.CompareTag("Shark"))
        {
            actionParticle.Play();
            Destroy(other.gameObject);
            gameOver = true;
            Time.timeScale = 0;
            Debug.Log("Game Over!");

        }
        else if (gameObject.CompareTag("Powerup"))
        {
            actionParticle.Play();
            Destroy(gameObject);
            Debug.Log("Player has hit Powerup! Do something...");
        }
    }
}
