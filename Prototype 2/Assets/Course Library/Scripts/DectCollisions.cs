using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DectCollisions : MonoBehaviour
{
  public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Animal"))
        {
            Destroy(gameObject);
        }
        
        if(other.CompareTag("Pizza"))
        {
            Destroy(gameObject);
            score++;
            Debug.Log("Has ganado un:" + score);
            Destroy(other.gameObject);
        }
    }
}
