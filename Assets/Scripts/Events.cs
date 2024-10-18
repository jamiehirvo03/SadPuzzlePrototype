using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    public static Events current;

    private void Awake()
    {
        current = this;
    }

    //Events that tell the cube to rotate 90 degrees in a direction
    public event Action onCubeRotateLeft;
    public event Action onCubeRotateRight;
    public event Action onCubeRotateUp;
    public event Action onCubeRotateDown;

    public event Action onPuzzleSuccess;
    public event Action onPuzzleFail;

    public event Action onGameWin;
    public event Action onGameOver;

    public void CubeRotateLeft()
    {
        if (onCubeRotateLeft != null)
        {
            onCubeRotateLeft();
        }
    }
    public void CubeRotateRight()
    {
        if (onCubeRotateRight != null)
        {
            onCubeRotateRight();
        }
    }
    public void CubeRotateUp()
    {
        if (onCubeRotateUp != null)
        {
            onCubeRotateUp();
        }
    }
    public void CubeRotateDown()
    {
        if (onCubeRotateDown != null)
        {
            onCubeRotateDown();
        }
    }
}
