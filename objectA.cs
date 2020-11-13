using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectA : MonoBehaviour
{
    // Start is called before the first frame update
    public DelegateHandler CollisionHandler;
    public MainSceneController SceneController;
    public float distanceToPlayer;

    void Start()
    {
        CollisionHandler.col += PrintMessage;
        SceneController.pshot += PlayerShot;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void PrintMessage()
    {   
        Debug.Log("¡El jugador ha impactado con el objeto B!");
    }

    void PlayerShot()
    {
        distanceToPlayer = Vector3.Distance(GameObject.Find("shadowElEriso").transform.position, transform.position);
        if(distanceToPlayer < SceneController.ShortRange)
        {
            Debug.Log("Object A " + name + " at short range (" + distanceToPlayer+ ")");
            SceneController.pshot -= PlayerShot;
            Destroy(gameObject, 0);
        }
        else if(distanceToPlayer < SceneController.MediumRange)
        {
            Debug.Log("Object A " + name + " at medium range (" + distanceToPlayer+ ")");
			// how much the character should be knocked back
			float magnitude = 2000 * distanceToPlayer;
			// calculate force vector
			var force = transform.position - GameObject.Find("shadowElEriso").transform.position;
			// normalize force vector to get direction only and trim magnitude
			force.Normalize();
			gameObject.GetComponent<Rigidbody>().AddForce(force * magnitude);
        }
    }
}
