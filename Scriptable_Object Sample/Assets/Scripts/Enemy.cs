using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyScritableObject enemy;

    private string enemy_Name;
    private Renderer color;
    private Transform scale;

    private void Awake()
    {
       color = GetComponent<Renderer>();
       scale = GetComponent<Transform>();
    }

    private void Start()
    {
        color.material.color = enemy.skin_Color;
        scale.localScale = enemy.enemyScale;
        enemy_Name = enemy.enemyTypeName;
    }

    private void Update()
    {
        PrintEnemyName();
    }

    void PrintEnemyName()
    {
        if (enemy_Name != null && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"{enemy_Name}");
        }
    }
}
