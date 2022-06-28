using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIScoreController : MonoBehaviour
{
    [Header("UI")]
    public TMP_Text score;
    public TMP_Text highScore;
    [Header("Score")]
    public ScoreController scoreController;
    private void Update()
    {
        score.text = scoreController.GetCurrentScore().ToString();
        highScore.text = ScoreData.highScore.ToString();
    }
}
