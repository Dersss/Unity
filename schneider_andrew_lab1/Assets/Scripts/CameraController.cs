using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float minX = -60f;
    public float maxX = 60f;
    public float minY = -360f;
    public float maxY = 360f;

    public float sensitivityX = 15f;
    public float sensitivityY = 15f;
    public Camera cam;
    float rotationY = 0f;
    float rotationX = 0f;
    public GameObject player;

    private Vector3 offset;

    void Start ()
    {
        offset = transform.position - player.transform.position;
        Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKey(KeyCode.Escape)) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }    
    }
    void Update() {
        rotationX += Input.GetAxis("Mouse Y") * sensitivityX;
        rotationY += Input.GetAxis("Mouse X") * sensitivityY;
        

        rotationX = Mathf.Clamp(rotationX, minX, maxX);
        transform.localEulerAngles = new Vector3(0, rotationY, 0);
        cam.transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);
        cam.transform.position = player.transform.position + offset;
    }
}