using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ScoreScripts : MonoBehaviour
{
    public TextMeshProUGUI Score;
    public static float TotalScore;

    private void Start()
    {
        TotalScore = 0;
    }
    void Update()
    {
        Score.text = TotalScore.ToString();
        if (TotalScore>PlayerPrefs.GetInt("_highScore"))
        {
            PlayerPrefs.SetInt("_highScore", (int)TotalScore);
        }
        
    }
}
