using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesSwitch : MonoBehaviour
{
    //private void Start()
    //{
    //    SceneManager.LoadScene(1);
    //}

    public void OpenClick()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Achievements()
    {
        SceneManager.LoadScene(2);
    }
}
