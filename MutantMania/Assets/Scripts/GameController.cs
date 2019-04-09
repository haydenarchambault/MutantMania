﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text deathText;
    public GameObject player;

	// Use this for initialization
	void Start ()
    {
        deathText.text = "";
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Quit");
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("MainScene");
        }

        if (!player.activeSelf)
        {
            deathText.text = "Press [R] to restart or [ESC] to quit";
        }
    }
}
