using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_click : MonoBehaviour
{
    [SerializeField] public static int score;
    public Text scoreText;

    public void click()
    {
        score++;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
