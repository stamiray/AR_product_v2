﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameController : MonoBehaviour
{
    public static string currentSelectedCar = "myLamboConvert";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void quit()
    {
        Application.Quit();
    }
    public void changeLevel(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
