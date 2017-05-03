using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    public GameObject mainCamera;
    public float movementSpeed = 0.01f;
    public Vector3 mouseOrigin;
    public float xMotion;
    public float yMotion;

    //debug values
    public Vector3 cameraPosition;
    public Quaternion cameraRotation;
    public Vector3 mouseMovement;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            castToMeshCollider();
        }
    }

    // Rotate freely in place at a fixed speed
    public void freeRotate()
    {
        cameraPosition = mainCamera.transform.position;
        cameraRotation = mainCamera.transform.rotation;

        if (Input.GetMouseButtonDown(1))
        {
            mouseOrigin = Input.mousePosition;
        }

        //On Right Click Hold Rotate Camera
        if (Input.GetMouseButton(1))
        {
            mouseMovement = Input.mousePosition - mouseOrigin;
            if (mouseMovement.x > 0)
            {
                xMotion = 1.0f;
            }
            else if (mouseMovement.x < 0)
            {
                xMotion = -1.0f;
            }

            if (mouseMovement.y > 0)
            {
                yMotion = 1.0f;
            }
            else if (mouseMovement.y < 0)
            {
                yMotion = -1.0f;
            }
            mainCamera.transform.Rotate(Vector3.up, mouseMovement.x * movementSpeed);
            mainCamera.transform.Rotate(Vector3.left, mouseMovement.y * movementSpeed);
        }
    }

    //Raycast to Mesh Colliders
    public void castToMeshCollider()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            print(hit.point);
        }
    }
}
