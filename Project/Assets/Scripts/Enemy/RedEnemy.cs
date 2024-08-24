using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemy : AbstractEnemy
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
        enemyClass = EnemyClass.Grunt;
        attackPower = 2;
        health = 1;
        speed = 1;
        spawnRate = 0.4f;
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
            attackPower += 1;
        }
        else if (GameManager.currentTime == TimeOfDay.Night)
        {
            // Do nothing
        }
    }
}