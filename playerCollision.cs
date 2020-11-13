using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public MainSceneController mainController;

    // Start is called before the first frame update
    void Start()
    {
        mainController.bimp += ChangeSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
		if (collision.collider.tag == "Player")
		{
			mainController.ChangeSizeTrigger();
		}      
    }

    void ChangeSize()
    {
        // Efecto en objectos B
        GetComponent<Transform>().localScale += new Vector3(10, 10, 10);
        GetComponent<Rigidbody>().mass *= 1000;

        // Efecto en jugador (negativo)

        GameObject.Find("shadowElEriso").GetComponent<MoveBehaviour>().runSpeed = 0.3f;
    }
}
