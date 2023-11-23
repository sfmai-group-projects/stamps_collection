using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesSwitch : MonoBehaviour
{
  public void OpenMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void OpenClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
