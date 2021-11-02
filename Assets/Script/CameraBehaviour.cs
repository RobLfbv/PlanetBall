using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{

    public Transform target;
    public float upDistance = 7.0f;
    public float backDistance = 10.0f;
    public float trackingSpeed = 3.0f;
    public float rotationSpeed = 9.0f;

    private Vector3 v3To;
    private Quaternion qTo;

    void LateUpdate()
    {
        v3To = target.position - target.forward * backDistance + target.up * upDistance;
        transform.position = Vector3.Lerp(transform.position, v3To, trackingSpeed * Time.deltaTime);
        qTo = Quaternion.LookRotation(target.position - transform.position, target.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, qTo, rotationSpeed * Time.deltaTime);
    }
}