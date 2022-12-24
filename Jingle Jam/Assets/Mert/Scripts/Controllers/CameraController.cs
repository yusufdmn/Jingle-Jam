using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera mainCam;
    public Transform playerTransform;
    public float smoothDamp = 0.15f;
    public Vector3 offset;
    Vector3 velocity = Vector3.zero;

    private void Update()
    {
        Vector3 targetPos = playerTransform.position + offset;
        mainCam.transform.position = Vector3.SmoothDamp(mainCam.transform.position, targetPos, ref velocity, smoothDamp);
    }
}   
