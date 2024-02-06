using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyMover _enemyMover;

    private void Awake()
    {
        _enemyMover = GetComponent<EnemyMover>();
    }

    public void Init(Vector2 direction)
    {
        _enemyMover.SetDirection(direction);
    }
}
