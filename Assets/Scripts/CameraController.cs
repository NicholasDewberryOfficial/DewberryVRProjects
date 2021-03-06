using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float minimumX = -60f;
    public float maximumX = 60f;
    public float minimumY = -360f;
    public float maximumY = 360f;

    public float sensitivityX = 15f;
    public float sensitivityY = 15f;

    public Camera cam;

    float rotationY = 0f;
    float rotationX = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivityY;
        rotationX += Input.GetAxis("Mouse Y") * sensitivityX;
        
        rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);
        //rotationY = Mathf.clamp(rotationY, minimumY, maximumY);

        transform.localEulerAngles = new Vector3(0, rotationY, 0);

        cam.transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);
    }
}
