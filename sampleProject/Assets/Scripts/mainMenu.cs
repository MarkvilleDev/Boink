using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }
    public void Settings()
    {
        SceneManager.LoadScene(3);
    }
    public void Skin()
    {
        SceneManager.LoadScene(4);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToLevelSelector()
    {
        SceneManager.LoadScene(2);
    }
    public void BackToSettings()
    {
        SceneManager.LoadScene(3);
    }
    public void BackToSkins()
    {
        SceneManager.LoadScene(4);
    }
    public void Level_1()
    {
        SceneManager.LoadScene(5);
    }
}
