using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    public GameObject mainCamera;
    public GameObject identifier;

    //freeRotate
    public float movementSpeed = 0.01f;
    Vector3 mouseOrigin;
    float xMotion;
    float yMotion;
    Vector3 mouseMovement;

    //castToMeshCollider
    Vector3 oldHitPoint = new Vector3(0, 0, 0);

    //focusOnPoint
    Vector3 clickLocation = new Vector3(0, -10, 0);
    Vector3 direction;
    Quaternion lookRotation;
    public float rotationSpeed = 2.0f;    

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        rightClickFocus();
    }

    // Rotate freely in place at a fixed speed
    public void freeRotate()
    {
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
            mainCamera.transform.Rotate(Vector3.up, xMotion * movementSpeed);
            mainCamera.transform.Rotate(Vector3.left, yMotion * movementSpeed);
        }
    }

    //Raycast to Mesh Colliders
    public Vector3 castToMeshCollider()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            oldHitPoint = hit.point;
            return hit.point;
        }

        return oldHitPoint;
    }

    //Hold Right Click to Move Camera to Focus
    public void rightClickFocus()
    {
        if (Input.GetMouseButtonDown(1))
        {
            clickLocation = castToMeshCollider();
        }
        focusOnPoint(clickLocation);
    }

    //Move Camera to focus on Point
    public void focusOnPoint(Vector3 point)
    {
        direction = (point - mainCamera.transform.position).normalized;
        lookRotation = Quaternion.LookRotation(direction);
        mainCamera.transform.rotation = Quaternion.Slerp(mainCamera.transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
    }
}
