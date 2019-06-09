using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public ScoreKeeper ScoreKeeper;
    public float TimeBetweenSpawns = 5;
    public List<GameObject> EnemyGroups;

    int groupsSpawned = 0;
    float timeTillNextSpawn = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScoreKeeper.SetCurrentScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        timeTillNextSpawn -= Time.deltaTime;
        if(timeTillNextSpawn <= 0)
        {
            SpawnGroup();
        }
    }

    public void SpawnGroup()
    {
        int groupNumber = Random.Range(0, EnemyGroups.Count - 1);
        var groupToSpawn = EnemyGroups[groupNumber];
        var group = Instantiate(groupToSpawn, new Vector2(20,0), Quaternion.identity);
        Destroy(group.gameObject, 12);
        timeTillNextSpawn = TimeBetweenSpawns;
        groupsSpawned++;
        if(groupsSpawned % 5 == 0)
        {
            TimeBetweenSpawns -= .5f;
            if(TimeBetweenSpawns < 1.5)
            {
                TimeBetweenSpawns = 1.5f;
            }
        }

    }
}
