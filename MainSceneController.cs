using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneController : MonoBehaviour
{
    public delegate void PlayerShot();
    public event PlayerShot pshot;

    public delegate void BImpact();
    public event BImpact bimp;    

    public delegate void ItemCollection();
    public event ItemCollection gate;      

    public float ShortRange = 5;
    public float MediumRange = 10;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            if(pshot != null)
            {
                pshot();
            }
        }
    }

    public void ChangeSizeTrigger()
    {
        bimp();
    }

    public void GateTrigger()
    {
        gate();
    }
}
