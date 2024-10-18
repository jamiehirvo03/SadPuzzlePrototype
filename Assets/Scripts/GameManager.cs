using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Events.current.CubeRotateUp();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Events.current.CubeRotateLeft();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Events.current.CubeRotateDown();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Events.current.CubeRotateRight();
        }
    }
}
