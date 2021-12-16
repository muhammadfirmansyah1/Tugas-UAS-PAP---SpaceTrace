using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<WaveConfigSO> waveConfigs;
    [SerializeField] float timeBetweenWaves = 0f;
    [SerializeField] bool isLooping;
    WaveConfigSO currentWave;
    void Start()
    {
        StartCoroutine (SpawnEnemiesWave());
    }

    public WaveConfigSO GetCurrentWave()
    {
        return currentWave;
    }

    // Method untuk spawn Enemy 
    IEnumerator SpawnEnemiesWave()
    {
        do 
        {
        foreach(WaveConfigSO wave in waveConfigs)
        {
            currentWave = wave;
            for(int i = 0; i < currentWave.GetEnemyCount(); i++)
            {
            Instantiate(currentWave.GetEnemyPrefab(i), currentWave.GetStartingWaypoint().position, Quaternion.Euler(0,0,90), transform);

            yield return new WaitForSeconds(currentWave.GetRandomSpawnTime());       
            }
        yield return new WaitForSeconds(timeBetweenWaves);
        }
        }
        while(isLooping);
    }
}
