using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BigObj : Obj
{
    private int score ;
    public override void ScoreCount(Player player)
    {
        score = Random.Range(1, 6);
        Debug.Log("You Got Big Soul!");
        player.ScoreCalculate(score * 5);
    }
}
