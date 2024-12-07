using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Character player;
    [SerializeField] private Vector2 velocity;
    [SerializeField] private Transform[] movePoints;
    [SerializeField] private Transform spawnPoint;
    public Transform SpawnPoint { get { return spawnPoint; } set { spawnPoint = value; } }
    private float time;
    public void Update()
    {
        Move();
        time += Time.deltaTime;
        Shoot();
    }
    public void Move()
    {
        rb.MovePosition(rb.position + velocity * Time.deltaTime);

        if (rb.position.y <= movePoints[0].position.y && velocity.y < 0)
        {
            Flip();
        }
        else if (rb.position.y >= movePoints[1].position.y && velocity.y > 0)
        {
            Flip();
        }
    }
    private void Flip()
    {
        velocity *= -1;
        Vector2 scale = transform.localScale;
        scale.y *= -1;
        transform.localScale = scale;
    }
    public void Shoot()
    {
        if (time >= 2)
        {
            bullet = Instantiate(bullet, SpawnPoint.position, Quaternion.identity);
            Bullet Bullet = bullet.GetComponent<Bullet>();
            time = 0;
        }
    }
}
