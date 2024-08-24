using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject [] enemies;
    [SerializeField] private float timeUntilSpawn;
    [SerializeField] private float[] rates;
    private float total;
    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        rates = new float [enemies.Length];
        currentTime = timeUntilSpawn;
        // Copies all enemy's spawn rates individually with matching array indexes into array
        // and sums the all therates in total
        for (int i = 0; i < enemies.Length; i++)
        {
            rates[i] = enemies[i].GetComponent<AbstractEnemy>().ReturnSpawnRate();
            total += enemies[i].GetComponent<AbstractEnemy>().ReturnSpawnRate();
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        // When currentTime reaches 0 or less than, spawns random enemy and resets currentTime
        if (currentTime <= 0)
        {
            Instantiate(enemies[GetRandomIndex()], transform.position, Quaternion.identity).SetActive(true);
            currentTime = timeUntilSpawn;
        }
    }
    // EFFECTS: Returns a random index that was chosen using the enemies' spawn rates for that Spawner
    private int GetRandomIndex()
    {
        float random = Random.Range(0f, 1f);
        float numForAdding = 0f;
   
        for (int i = 0; i < enemies.Length; i++)
        {
            if (random <= ((rates[i] / total) + numForAdding))
            {
                return i;
            }
            else
            {
                numForAdding += rates[i] / total;
            }
        }
        return 0;
    }      
}