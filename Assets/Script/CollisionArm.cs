using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionArm : MonoBehaviour
{
    GameObject ball;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.name == "Ball")
        {
            
        }
    }
}
