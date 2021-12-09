using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCameraScript : MonoBehaviour
{
    Vector3 CameraMovement; 
    public float CameraSpeed = 50f;
    public float dragSpeed = 2;
    private Vector3 dragOrigin;
    Vector2 mouseClickPos;
    Vector2 mouseCurrentPos;
    bool panning = false;

    //We use for movement since it is part of unity phisics
    void FixedUpdate()
    {
        CameraMovement.x = Input.GetAxis("Horizontal");
        CameraMovement.y = Input.GetAxis("Vertical");
        transform.position = transform.position + CameraMovement * CameraSpeed * Time.fixedDeltaTime;
    }

    void Update()
    {

        // When LMB clicked get mouse click position and set panning to true
        if (Input.GetKeyDown(KeyCode.Mouse0) && !panning)
        {
            mouseClickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            panning = true;
        }
        // If LMB is already clicked, move the camera following the mouse position update
        if (panning)
        {
            mouseCurrentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var distance = mouseCurrentPos - mouseClickPos;
            transform.position += new Vector3(-distance.x,-distance.y,0);
        }
 
        // If LMB is released, stop moving the camera
        if (Input.GetKeyUp(KeyCode.Mouse0))
            panning = false;
    

        //Drag and glide with right click
        if (Input.GetMouseButtonDown(1))
        {
            dragOrigin = Input.mousePosition;
            return;
        }
 
        if (!Input.GetMouseButton(1)) return;
 
        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(pos.x * dragSpeed, pos.y * dragSpeed, 0);
 
        transform.Translate(move, Space.World);
    }
        
}
