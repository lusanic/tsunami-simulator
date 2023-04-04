using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDragRotate : MonoBehaviour
{
    public float speed = 0.2f;

    private Vector3 lastMousePos;

    private void OnMouseDown()
    {
        Debug.Log("MouseDown");
        lastMousePos = Input.mousePosition;
    }

    private void OnMouseDrag()
    {
        Debug.Log("MouseDrag");
        Vector3 delta = Input.mousePosition - lastMousePos;
        lastMousePos = Input.mousePosition;

        float horizontalRotation = -delta.x * speed;

        // Lock vertical rotation
        Vector3 currentRotation = transform.rotation.eulerAngles;
        float verticalRotation = currentRotation.x;
        Quaternion targetRotation = Quaternion.Euler(verticalRotation, currentRotation.y + horizontalRotation, currentRotation.z);

        transform.rotation = targetRotation;
    }
}