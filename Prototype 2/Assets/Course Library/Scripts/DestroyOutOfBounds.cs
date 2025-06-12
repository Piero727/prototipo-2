using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float limitZ = 29f;
    private float limitX = 29f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > limitZ)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < -limitZ)
        {
            
            Destroy(gameObject);
        }

        if(transform.position.x >limitX)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -limitX)
        {
            Destroy(gameObject);
        }
    }
}
