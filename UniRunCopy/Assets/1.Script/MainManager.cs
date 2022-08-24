using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainManager : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }
    public void GameExit()
    {
        Application.Quit();
    }
}