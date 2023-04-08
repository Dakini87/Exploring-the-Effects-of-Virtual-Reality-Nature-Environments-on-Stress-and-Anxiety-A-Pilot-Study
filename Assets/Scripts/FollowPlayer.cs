using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    public float mouseSensitivity = 100f;
    public Transform playerBody;

    private float xRotationCamera = 0f;
    private float yRotationCamera = 0f;
    private Vector3 offset;
    public float turnSpeed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        offset = new Vector3(player.position.x, player.position.y + 8.0f, player.position.z + 7.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = player.transform.position; //+ new Vector3(0, 1, -5);
        
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotationCamera -= mouseY;
        xRotationCamera = Mathf.Clamp(xRotationCamera, -90f, 90f);
        
        yRotationCamera -= mouseX;
        yRotationCamera = Mathf.Clamp(xRotationCamera, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotationCamera, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
        transform.rotation = player.transform.rotation;
    }

   
}
