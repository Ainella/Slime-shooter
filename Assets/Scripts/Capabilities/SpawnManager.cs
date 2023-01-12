using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField]
    private Transform player;
    [SerializeField]
    private GameObject enemy;
    private Vector3 position;
    [SerializeField]
    private int _totalEnemies = 200;
    [SerializeField]
    private int _maxEnemies = 5;
    [SerializeField]
    private int _currentEnemies = 0;
    private bool checkpoint = false;

    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.x > 200 && !checkpoint)
        {
            NextCheckpoint();
            checkpoint = true;
        }
    }

    void StartSpawning()
    {
        StartCoroutine(SpawnEnemyRoutine());
    }

    private IEnumerator SpawnEnemyRoutine()
    {
        while (_totalEnemies > 0 && _currentEnemies != _maxEnemies)
        {
            _totalEnemies--;
            _currentEnemies++;
            position = new Vector3(Random.Range(player.position.x + 30f, player.position.x + 60f), player.position.y, 0);
            Instantiate(enemy, position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }

    public void EnemyDestroyed()
    {
        _currentEnemies--;
        if (_currentEnemies == _maxEnemies - 1)
        {
            StartSpawning();
        }
    }

    void NextCheckpoint()
    {
        if (_totalEnemies == 0)
        {
            _totalEnemies += 300;
            StartSpawning();
        }
        else
        {
            _totalEnemies += 300;
        }

    }
}
