using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileAttackArea : MonoBehaviour
{
    private bool active = true; // if it can hit the player
    public int damage = 0;

    // Upon attack triggered
    private void OnTriggerEnter2D(Collider2D collider)
    {
        PlayerStats stats = collider.GetComponent<PlayerStats>();
        if (stats != null)
        {
            // Deal damage to monsters
            stats.Damage(damage);
        }
    }
}
