﻿using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

    public Timer fTimer;
    void Update()
    {

        if (fTimer.timerDone)
        {
            Application.LoadLevel("Map_Layout");
        }
    }
}
