using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] Transform player;
    [SerializeField] float spawnRate = 2f, spawnRadius = 4f, minDistanceFromPlayer = 6.5f;
    private float spawnTimer = 0;

    void Start()
    {
        
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnRate)
        {
            spawnEnemy();
            spawnTimer = 0;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, spawnRadius);
    }

    private void spawnEnemy()
    {
        Vector2 randomPosition;
        do
        {
            randomPosition = (Vector2)transform.position + Random.insideUnitCircle * spawnRadius;
        } while (Vector2.Distance(randomPosition, player.position) < minDistanceFromPlayer);

        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
}