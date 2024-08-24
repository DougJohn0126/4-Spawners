using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEnemy : AbstractEnemy
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void SetStats()
    {
        enemyClass = EnemyClass.Assassin;
        attackPower = 1;
        health = 1;
        speed = 2;
        spawnRate = 0.2f;
    }

    public override void TimeEffects()
    {
        SetStats();
        if (GameManager.currentTime == TimeOfDay.Morning)
        {
            // Do nothing
        }
        else if (GameManager.currentTime == TimeOfDay.Afternoon)
        {
            spawnRate = 0f;
        }
        else if (GameManager.currentTime == TimeOfDay.Night)
        {
            speed += Random.Range(0, 2);
        }
    }
}