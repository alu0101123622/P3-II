using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateHandler : MonoBehaviour
{
    public delegate void CollisionWithPlayer();
    public event CollisionWithPlayer col;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other) {
        if(other.collider.tag == "Player") {
                col();
            }
        }
}