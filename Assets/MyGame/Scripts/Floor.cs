using UnityEngine;

public class Floor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.name.Contains("Present"))
        {
            Destroy(Collision.gameObject);
        }
        if (Collision.name.Contains("Brick"))
        {
            Destroy(Collision.gameObject);
        }
    }
}
