using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.TextCore.Text;

public class Bullet : Weapon
{
    private int speed = 10;
    public void Move()
    {
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
    }
    private void FixedUpdate()
    {
        Move();
    }
    public override void OnHitWith(Character player)
    {
        if (player is Player)
            player.ScoreCalculate(player, 5);
    }
}
