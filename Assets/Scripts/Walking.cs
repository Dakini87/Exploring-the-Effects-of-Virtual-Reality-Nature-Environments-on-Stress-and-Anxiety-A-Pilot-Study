using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // moving to left / right
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate( new Vector3(0,0,1) * Time.deltaTime * speed * verticalInput);
    }
}
