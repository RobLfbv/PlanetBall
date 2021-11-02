using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 15;
    private Vector3 moveDir;

    public Transform Cam;

    public GameObject arm;
    public GameObject ball;

    private int c = 0;
    private int slowdown = 0;


    void Update()
    {
        moveSpeed = 15;
        if (c<72 && c>0)
        {
            RotateArm(5,0.02f);
        }
        else
        {
            c = 0;
        }
        if (Input.GetKeyDown("space") && c==0)
        {
            slowdown++;
            RotateArm(5,0.02f);        
        }
        if (Input.GetKey(KeyCode.LeftShift) && slowdown == 0)
        {
            print("SPEEEEEEEEEED");
            moveSpeed = 25;
        }
        if (slowdown>0 && slowdown <72)
        {
            moveSpeed = 5;
            slowdown++;

        }
        else if(slowdown>=72)
        {
            slowdown = 0;
        }

        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;

    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDir) * moveSpeed * Time.deltaTime);
    }



    void RotateArm(float xR, float xT)
    {
        c++;
        arm.transform.Rotate(0,0,xR, Space.Self);
    }
}
