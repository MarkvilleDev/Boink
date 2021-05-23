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
    public void Level_0()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(5);
        //GameObject.FindGameObjectWithTag("Music").GetComponent<musicClass>().PlayMusic();
    }
    public void Level_1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(6);
    }
    public void Level_2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(7);
    }
    public void Level_3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(8);
        //GameObject.FindGameObjectWithTag("Music").GetComponent<musicClass>().PlayMusic();
    }
    public void Level_4()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(9);
    }
    public void Level_5()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(10);
    }
    public void Level_6()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(11);
    }
    public void Level_7()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(12);
    }
    public void Level_8()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(13);
    }
    public void Level_9()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(14);
    }
    public void Level_10()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(15);
    }
    public void Level_11()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(16);
    }
    public void Level_12()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(17);
    }
    public void Level_13()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(18);
    }
    public void Level_14()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(19);
    }
    public void Level_15()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(20);
    }
    public void Level_16()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(21);
    }
    public void Level_17()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(22);
    }
}
