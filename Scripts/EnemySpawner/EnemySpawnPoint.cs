using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    public void SpawnEnemy(Enemy enemyPrefab)
    {
        Enemy spawned = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        spawned.Init(transform.rotation);
    }
}
