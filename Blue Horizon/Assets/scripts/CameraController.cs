using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform target;
    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        target = GameObject.Find("player").GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        // Define a target position above and behind the target transform
       // Debug.Log(target.TransformPoint(new Vector3(0, 4, -3)));
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 4, -3));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime, Mathf.Infinity);
        transform.LookAt(target);
        // Smoothly move the camera towards that target position

    }
}
