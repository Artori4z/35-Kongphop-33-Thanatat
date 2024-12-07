using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private int scoreCal;
    public int ScoreCal { get { return scoreCal; } set { scoreCal = value; } }
    public Rigidbody2D rb;
    public void ScoreCalculate(int _scoreCal)
    {
        ScoreCal += _scoreCal;
    }
    public void ScoreCalculate(Character player, int _scoreCal)
    {
        if (player is Player) 
        {
            Debug.Log("You got hit!!!");
        }
        ScoreCal -=_scoreCal;
    }

}
