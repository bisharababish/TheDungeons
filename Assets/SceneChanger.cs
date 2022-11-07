using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void next()
    {
        SceneManager.LoadScene("level_1");
    }

    public void levelOne()
    {
        SceneManager.LoadScene("level_1");
    }

    public void levelTwo()
    {
        SceneManager.LoadScene("level_2");
    }

    public void levelThree()
    {
        SceneManager.LoadScene("level_3");
    }

    public void levelGet()
    {
        SceneManager.LoadScene("Load Levels");
    }

    public void gotohome()
    {
        SceneManager.LoadScene("home");
    }
    
    public void Demo()
    {
        SceneManager.LoadScene("Demo");
    }

    public void nogo()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("bye bye");
        Application.Quit();
    }

}
