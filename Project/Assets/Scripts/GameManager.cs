using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Give global access to enumerator  
public enum TimeOfDay {Morning, Afternoon, Night};

public class GameManager : MonoBehaviour
{
    public static TimeOfDay currentTime;
    [SerializeField] private AbstractEnemy[] enemies;
    [SerializeField] private TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Awake is called when the script instance is being loaded.
    private void Awake()
    {
        // Set currentTime
        currentTime = (TimeOfDay)Random.Range(0, System.Enum.GetValues(typeof(TimeOfDay)).Length);

        // Called once only in the beginning
        SetAllTimeEffects();

        // Changes time text
        if (currentTime == TimeOfDay.Morning)
        {
            timeText.text = "Morning";
        }
        else if (currentTime == TimeOfDay.Afternoon)
        {
            timeText.text = "Afternoon";
        }
        else if (currentTime == TimeOfDay.Night)
        {
            timeText.text = "Night";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // REQUIRES: All enemies that will be in the scene to be prereferenced in the array
    // EFFECTS: Calls TimeEffects() for all enemies that are present in the array of enemies (that are present in the scene)
    void SetAllTimeEffects()
    {
        foreach (AbstractEnemy enemy in enemies )
        {
            enemy.TimeEffects();
        }
    }
}