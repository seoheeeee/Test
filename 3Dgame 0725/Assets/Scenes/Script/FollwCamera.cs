using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollwCamera : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;

    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
