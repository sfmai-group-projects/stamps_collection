using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_click : MonoBehaviour
{
    [SerializeField] int score;
    public Text scoreText;

    private void Start()
    {
       score = PlayerPrefs.GetInt("score");
    }

    public void click()
    {
        score++;
        PlayerPrefs.SetInt("score", score);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
