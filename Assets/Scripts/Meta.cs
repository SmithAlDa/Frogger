﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D() {
        Debug.Log("winah!");
        Score.currentScore += 100; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
