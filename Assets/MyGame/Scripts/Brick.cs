using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Brick");
    }

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Hallo Santa");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
