using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowEnemy : AbstractEnemy
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
        enemyClass = EnemyClass.Archer;
        attackPower = 5;
        health = 1;
        speed = 1;
        spawnRate = 0.1f;
    }

    public override void TimeEffects()
    {
        SetStats();
        if (GameManager.currentTime == TimeOfDay.Morning)
        {
            spawnRate += Random.Range(0.2f, 0.4f);
        }
        else if (GameManager.currentTime == TimeOfDay.Afternoon)
        {
            spawnRate += Random.Range(-0.2f, 0.2f);
        }
        else if (GameManager.currentTime == TimeOfDay.Night)
        {
            // Do nothing
        }
    }
}