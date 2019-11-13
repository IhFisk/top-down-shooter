﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public int EnemyHealth = 20;
    public int EnemyDamage = 5;

    // Start is called before the first frame update
    void Start()
    {
        setHealth(EnemyHealth);
        setDamage(EnemyDamage);
    }
    
    protected override void Die()
    {
        Destroy(gameObject);
    }
}
