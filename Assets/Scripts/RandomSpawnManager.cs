using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnManager : MonoBehaviour
{

    public GameObject playerPrefab;
    public GameObject ghostPrefab;
    public Transform[] spawnPoints; 
    void Start()
    {
        SpawnCharacters();
    }

    void SpawnCharacters()
    {
        
        List<int> availableSpawns = new List<int>();

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            availableSpawns.Add(i);
        }

      
        int playerSpawn = GetRandomSpawn(availableSpawns);
        Instantiate(playerPrefab,spawnPoints[playerSpawn].position, Quaternion.identity);

      
        for (int i = 0; i < 3; i++)
        {
            int ghostSpawn = GetRandomSpawn(availableSpawns);

            Instantiate(ghostPrefab,spawnPoints[ghostSpawn].position,Quaternion.identity);
        }
    }

    int GetRandomSpawn(List<int> availableSpawns)
    {
        int randomIndex = Random.Range(0, availableSpawns.Count);
        int spawnIndex = availableSpawns[randomIndex];

        availableSpawns.RemoveAt(randomIndex);

        return spawnIndex;
    }
}