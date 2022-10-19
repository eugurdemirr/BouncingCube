using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class ScoreGenerator : MonoBehaviour
{
    public TextMeshProUGUI HighScore;
    public TextMeshProUGUI YourScore;
    void Start()
    {
        HighScore.text = PlayerPrefs.GetInt("_highScore").ToString();
        YourScore.text = ScoreScripts.TotalScore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(1);
            
        }
        if (Input.GetMouseButton(1))
        {
            SceneManager.LoadScene(0);
        }
    }
}
