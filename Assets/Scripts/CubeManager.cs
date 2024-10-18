using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Events.current.onCubeRotateLeft += OnCubeRotateLeft;
        Events.current.onCubeRotateRight += OnCubeRotateRight;
        Events.current.onCubeRotateUp += OnCubeRotateUp;
        Events.current.onCubeRotateDown += OnCubeRotateDown;

    }

    private void OnCubeRotateLeft()
    {
        //cube is rotated left
    }

    private void OnCubeRotateRight()
    {
        //cube is ro
    }

    private void OnCubeRotateUp()
    {

    }

    private void OnCubeRotateDown()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
