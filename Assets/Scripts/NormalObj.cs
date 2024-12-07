using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class NormalObj : Obj
{
    private int score = 1;
    public override void ScoreCount(Player player)
    {
        player.ScoreCalculate(score);
    }
    
}
