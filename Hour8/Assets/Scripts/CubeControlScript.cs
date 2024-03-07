using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
    public GameObject mainCamera;

    Vector3 originalScale;
    Vector3 doubleScale;
    bool isEnlarged = false;

    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale;
        doubleScale = originalScale * 2;
    }

    // Update is called once per frame
    void Update()
    {
        moveCube();
        mouseMovement();
        MPressed();
    }

    void moveCube()
    {
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");

        float xVal = (hVal * Time.deltaTime) + transform.position.x;
        float zVal = (vVal * Time.deltaTime) + transform.position.z;

        transform.position = new Vector3(xVal, transform.position.y, zVal);
    }

    void mouseMovement()
    {
        float camRot = Input.GetAxis("Mouse Y");
        float cubeRot = -Input.GetAxis("Mouse X");
        transform.Rotate(0f, cubeRot, 0f);
        mainCamera.transform.Rotate(camRot, 0f, 0f);
    }

    void MPressed()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isEnlarged)
            {
                isEnlarged = false;
                transform.localScale = originalScale;
            }
            else
            {
                isEnlarged = true;
                transform.localScale = doubleScale;
            }
        }
    }
}
