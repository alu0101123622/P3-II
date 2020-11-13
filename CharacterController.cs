using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Transform tf;
    public float velocity;
    public Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
      tf = GetComponent<Transform>();
            velocity = 6.0f;
    }

    // Update is called once per frame
        void Update() 
        {
            float xAxis = 0;
            float zAxis = 0;
            if (Input.GetKey("w")) {
                xAxis += 1;
            }
            if (Input.GetKey("a")) {
                zAxis += 1;
            }
            if (Input.GetKey("s")) {
                xAxis -= 1;
            }
            if (Input.GetKey("d")) {
                zAxis -= 1;
            }
            movement = new Vector3(xAxis * velocity, 0, zAxis * velocity);
            tf.Translate(movement * Time.deltaTime);
    }
}
