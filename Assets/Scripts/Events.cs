using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    public static Events current;

    public void Awake()
    {
        current = this;
    }

    public event Action onPlayerCrying;

    public void PlayerCrying()
    {
        if (onPlayerCrying != null)
        {
            onPlayerCrying();
        }
    }
}
