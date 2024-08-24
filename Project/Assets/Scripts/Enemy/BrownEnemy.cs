using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownEnemy : AbstractEnemy
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
        attackPower = 1;
        health = 2;
        speed = 1;
        spawnRate = 0.3f;
    }

    public override void TimeEffects()
    {
        SetStats();
        if (GameManager.currentTime == TimeOfDay.Morning)
        {
            spawnRate -= Random.Range(0.1f, 0.3f);
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