using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Give global access to enumerator  
public enum EnemyClass{Grunt, Archer, Assassin}

// Abstract class for Enemy
public abstract class AbstractEnemy : MonoBehaviour
{
    [SerializeField] protected EnemyClass enemyClass;
    [SerializeField] protected int attackPower;
    [SerializeField] protected int health;
    [SerializeField] protected int speed;
    [SerializeField] protected float spawnRate;

    // MODIFIES: THIS
    protected abstract void SetStats();
    // MODIFIES: THIS
    public abstract void TimeEffects();

    // EFFECTS: Returns spawnRate
    public float ReturnSpawnRate() {
        return spawnRate;
    }
}