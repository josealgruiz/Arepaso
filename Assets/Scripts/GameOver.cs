﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public void goToMenu(){
        SceneManager.LoadScene("Menu");
        PlayerPrefs.SetInt("health",3);
    }

}
