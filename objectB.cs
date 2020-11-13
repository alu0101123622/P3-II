using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectB : MonoBehaviour
{
    public DelegateHandler handler;

    public int collisionCounter;
    public float distanceToPlayer;
    // Start is called before the first frame update
    void Start()
    {
        collisionCounter = 0;
        handler.col += Counter;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Counter()
    {
        collisionCounter++;
    }


}
