﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAndExit : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnExitButtonClicked()
    {
        Application.Quit();
    }
}
