using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    [SerializeField]
    public SpawnManager spawnManager;
    [SerializeField]
    public Player pl;

    void Update()
    {

    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject == player)
        {
            pl.Damage();
            spawnManager.EnemyDestroyed();
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Bullet"))
        {
            spawnManager.EnemyDestroyed();
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
