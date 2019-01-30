using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform transformObject; //position of the object
    private Vector3 distance;
    private float smooth = 0.5f;

    void Start()
    {
        distance = transform.position - transformObject.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = transformObject.position + distance;
        transform.position = Vector3.Slerp(transform.position, newPosition,smooth);
    }
}
