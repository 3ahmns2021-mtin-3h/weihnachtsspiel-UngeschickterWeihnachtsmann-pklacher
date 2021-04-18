using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.name.Contains("Present"))
        {
            StartCoroutine(WaitBeforeDestroy());
            Destroy(Collision.gameObject);
        }
        if (Collision.name.Contains("Brick"))
        {
            StartCoroutine(WaitBeforeDestroy());
            Destroy(Collision.gameObject);
        }
    }

    public IEnumerator WaitBeforeDestroy()
    {
        Debug.Log("Wait for a second active");
        yield return new WaitForSeconds(3f);
    }

}
