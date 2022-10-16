using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EnemyData", menuName = "CodeAcademyDers8/EnemyData", order = 1)]
public class EnemyData : ScriptableObject 
{
    public int HP;
    public int damage;
    public float speed;
}
