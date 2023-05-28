using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class buttons : MonoBehaviour
{
    public void startGame(){
        SceneManager.LoadScene("MainLevel");
    }

    public void returnToMain(){
        SceneManager.LoadScene("TitleScreen");
    }

    public void exit(){
        Application.Quit();
    }
}
