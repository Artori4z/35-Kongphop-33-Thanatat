using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player : Character
{
    [SerializeField] private TextMeshProUGUI score;
    public void Awake()
    {
        ScoreCal = 0;
    }
    public void Update()
    {
        ShowScore();
    }
    public void ShowScore()
    {
        score.text = $"Soul : {ScoreCal}";
    }
    
}
