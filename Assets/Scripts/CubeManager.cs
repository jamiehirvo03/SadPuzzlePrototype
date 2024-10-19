using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public GameObject cube;

    [SerializeField] private Vector3 currentAngle;
    [SerializeField] private Vector3 targetAngle;

    public bool isRotating = false;

    public float rotationSpeed;
    public float rotationTime;

    // Start is called before the first frame update
    void Start()
    {
        Events.current.onCubeRotateLeft += OnCubeRotateLeft;
        Events.current.onCubeRotateRight += OnCubeRotateRight;
        Events.current.onCubeRotateUp += OnCubeRotateUp;
        Events.current.onCubeRotateDown += OnCubeRotateDown;

        cube = this.gameObject;

        rotationSpeed = 5f;
        rotationTime = 1f;

        currentAngle = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            currentAngle = new Vector3(
            Mathf.LerpAngle(currentAngle.x, targetAngle.x, (float)(1 - Math.Exp(-rotationSpeed * rotationTime))),
            Mathf.LerpAngle(currentAngle.y, targetAngle.y, (float)(1 - Math.Exp(-rotationSpeed * rotationTime))),
            Mathf.LerpAngle(currentAngle.z, targetAngle.z, (float)(1 - Math.Exp(-rotationSpeed * rotationTime))));

            if (currentAngle == targetAngle)
            {
                isRotating = false;
            }

            cube.transform.eulerAngles = currentAngle;
        } 
    }
    private void OnCubeRotateLeft()
    {
        Debug.Log("Cube is rotated left");

        targetAngle = new Vector3(currentAngle.x, (currentAngle.y + 90), currentAngle.z);

        isRotating = true;
    }

    private void OnCubeRotateRight()
    {
        //cube is rotated right
        Debug.Log("Cube is rotated right");

        targetAngle = new Vector3(currentAngle.x, (currentAngle.y - 90), currentAngle.z);

        isRotating = true;
    }

    private void OnCubeRotateUp()
    {
        //cube is rotated up
        Debug.Log("Cube is rotated up");

        targetAngle = new Vector3((currentAngle.x + 90), currentAngle.y, currentAngle.z);

        isRotating = true;
    }

    private void OnCubeRotateDown()
    {
        //cube is rotated down
        Debug.Log("Cube is rotated down");

        targetAngle = new Vector3((currentAngle.x - 90), currentAngle.y, currentAngle.z);

        isRotating = true;
    }

    
}
