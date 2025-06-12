using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public int sum= 0;
    private bool isGameOver = false;

    // Update is called once per frame
    void Update()
    {

        sum++;
        if (sum > 400)
        {
            sum = 400;
            isGameOver = true;
        }

        if (isGameOver == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //Vector3 vector = new Vector3(Random.Range(-20,8), 30, 0);
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
              
                isGameOver = false;
                sum = 0;

            }
        }
        
    }
}
