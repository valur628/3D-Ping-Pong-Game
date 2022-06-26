using UnityEngine;
using System.Collections;

public class GameResume : MonoBehaviour
{

    public bool paused;
    
	void Start ()
    {
        paused = false;
	}
	
	void Update ()
    {
            paused = !paused;
        if (paused)
        {
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            Time.timeScale = 1;
        }
    }
}﻿