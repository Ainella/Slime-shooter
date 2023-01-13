using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public GameObject GameOverMenu;

    [SerializeField]
    public int lives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage()
    {
        if (lives > 0)
        {
            lives--;
        }
        
        else
        {
            EnemyDeath();
            Time.timeScale = 0f;
            GameOverMenu.SetActive(true);
        }
    }

    void EnemyDeath()
    {
        Destroy(gameObject);
    }
}
