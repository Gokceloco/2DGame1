using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Player player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && player.GetIfAttacking())
        {
            collision.GetComponent<Enemy>().GetHit();
        }
    }
}
