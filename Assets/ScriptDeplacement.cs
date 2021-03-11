using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDeplacement : MonoBehaviour
{
    public float mouseSensitivityX = 100f;
    public float mouseSensitivityY = 50f;
    public float speed = 5f;
    //public Collision collision;
    public Transform playerBody;
    public Transform camera;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody rb = GetComponent<Rigidbody>();
        //rb.mass = 10f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //float speed = 10F; // meters per second

        //if(collision.rb){
            //speed = 10F;
        //}
        //else speed = 10.0F;
        
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(-x, y, 0);
        // left/right rotation

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivityX * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivityY * Time.deltaTime;

        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        camera.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.forward * mouseX);

        

    }

    void OnTriggerEnter(Collider col){
        speed = 0F;
    }
}