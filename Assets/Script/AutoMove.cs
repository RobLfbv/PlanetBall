using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 moveDir;
    public float dirX;
    public float dirZ;



    // Update is called once per frame
    void Update()
    {
        moveDir = new Vector3(moveSpeed*dirX, 0, moveSpeed*dirZ).normalized;

    }


    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.TransformDirection(moveDir) * moveSpeed * Time.deltaTime);
    }
}
