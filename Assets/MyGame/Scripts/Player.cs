using System.Collections;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    int countCollisions = 0;
    public PlayerController playerSpeed;
    private float playerSpeedBeforeHit;
    public int points = 0;
    public TextMeshProUGUI scoreDisplay;
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Brick"))
        {   
            Debug.Log("in if in Brick freeze");
            playerSpeedBeforeHit = playerSpeed.speed;
            playerSpeed.speed = 0;
            StartCoroutine(SetSpeedToZero());
        }
        else if(collision.name.Contains("Present"))
        {
            Destroy(collision.gameObject);
            Debug.Log("HIT PRESENT -------");
            points++;
            scoreDisplay.text = points.ToString();
        }

        Debug.Log("In Player, Collide with" + collision);
        Debug.Log("Count Collisions" + countCollisions);
    }

    public  IEnumerator SetSpeedToZero() 
    {
        yield return new WaitForSeconds(2f);
        playerSpeed.speed = playerSpeedBeforeHit;
    }

}
