using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private GameObject[] enemies;

    public bool AreAllEnemiesDead()
    {
        bool allEnemiesDead = true;

        foreach (GameObject enemy in enemies)
        {
            if (enemy.activeSelf)
            {
                allEnemiesDead = false;
                break;
            }
        }

        return allEnemiesDead;
    }

    private void Awake()
    {
        int characterCount = transform.childCount;
        enemies = new GameObject[characterCount];
        for (int i = 0; i < characterCount; i++)
        {
            enemies[i] = transform.GetChild(i).gameObject;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
