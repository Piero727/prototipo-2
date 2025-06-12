using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    public float verticalInput;
    public int positionX = 13;
    public int positionZ = 8;
    public GameObject foodPizza;

    public int vida = 3;
    public int score = 0;

    public static PlayerController Instance;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vida);
        Debug.Log(score);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * speed *horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        if (transform.position.x < -positionX)
        {
            transform.position = new Vector3( -positionX,transform.position.y, transform.position.z);
        }

        if(transform.position.x > positionX)
        {
            transform.position = new Vector3(positionX, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -positionZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -positionZ);
        }

        if (transform.position.z > positionZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, positionZ);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
           // Gracias a esto se va a instanciar el objeto de la pizza
            Instantiate(foodPizza, transform.position, foodPizza.transform.rotation);
        }

    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Animal"))
        {
            vida--;
            Debug.Log(vida);

            if (vida <= 0)
            {
                Debug.Log("Game Over");
                Destroy(gameObject);
            }
        }

        
    }
}
