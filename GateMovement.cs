using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateMovement : MonoBehaviour
{

    public MainSceneController mainController;
    public bool slide;
    public float slideSpeed;

    // Start is called before the first frame update
    void Start()
    {
        mainController.gate += SlideDown;
        slide = false;
        slideSpeed = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (slide == true)
        {
            if (GetComponent<Transform>().localPosition.y > -54)
            {
                transform.Translate(Vector3.down * slideSpeed * Time.deltaTime, Space.World);
            }

        }
    }

    void SlideDown()
    {
        slide = true;
    }
}
