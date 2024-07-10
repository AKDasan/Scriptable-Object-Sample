using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "EnemyType")]
public class EnemyScritableObject : ScriptableObject
{
    public string enemyTypeName;
    public Vector3 enemyScale = Vector3.one;
    public Color skin_Color;

    // public float damage;
    // public float speed;
    // public float rarity;
}
