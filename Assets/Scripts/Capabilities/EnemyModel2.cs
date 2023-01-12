using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModel2 : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > player.transform.position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
