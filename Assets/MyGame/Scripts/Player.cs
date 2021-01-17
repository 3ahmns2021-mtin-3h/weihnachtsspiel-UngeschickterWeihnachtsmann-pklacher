using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    int countCollisions = 0;
    public PlayerController playerSpeed;
    private float playerSpeedBeforeHit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.name == "Brick")
        {
            Debug.Log("In if In Brick -1");
            countCollisions--;
        }*/

        if (collision.name == "Brick")
        {   
            Debug.Log("in if in Brick freeze");
            Debug.Log(playerSpeed.speed);
            playerSpeedBeforeHit = playerSpeed.speed;
            playerSpeed.speed = 0;
            StartCoroutine(SetSpeedToZero());
        }
        else if(collision.name == "Present")
        {
            Debug.Log("in if in Present +1");
            countCollisions++;
        }

        Debug.Log("In Player, Collide with" + collision);
        Debug.Log("Count Collisions" + countCollisions);
    }

    public  IEnumerator SetSpeedToZero() 
    {
        yield return new WaitForSeconds(3f);
        playerSpeed.speed = playerSpeedBeforeHit;
    }

}
