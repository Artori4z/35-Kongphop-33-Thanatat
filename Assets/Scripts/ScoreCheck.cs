using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            Obj obj = GetComponent<Obj>();
            if (obj != null && player != null)
            {
                obj.ScoreCount(player);
                Destroy(this.gameObject);
            }
        }
    }
}
