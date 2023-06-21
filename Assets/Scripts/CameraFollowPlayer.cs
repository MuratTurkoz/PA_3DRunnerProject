using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform cameraTarget;
    [SerializeField] private float xSpeed = 10f;
    [SerializeField] private Vector3 dist;
    [SerializeField] private Transform lookTarget;
    // Start is called before the first frame update
    private void LateUpdate()
    {
        Vector3 dPos = cameraTarget.position + dist;
        Vector3 sPos = Vector3.Lerp(transform.position, dPos, xSpeed * Time.deltaTime);
        transform.position = sPos;
        transform.LookAt(lookTarget.position);
    }
}
