using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform lookAt;
    public Vector3 offset;
    public float smoothness;

    void LateUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 lookAtPos = lookAt.position + offset;
        Vector3 follow = Vector3.Lerp(transform.position, lookAtPos, smoothness);
        transform.position = follow;
        transform.LookAt(lookAt);
    }
}
