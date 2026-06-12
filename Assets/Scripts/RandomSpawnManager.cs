using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnManager : MonoBehaviour
{
    [Header("Prefabs")]
    public GameObject playerPrefab;
    public GameObject ghostPrefab;

    [Header("Pontos de Spawn")]
    public Transform[] spawnPoints; // Deve ter 4 pontos

    void Start()
    {
        SpawnCharacters();
    }

    void SpawnCharacters()
    {
        // Cria uma lista com os índices dos spawns
        List<int> availableSpawns = new List<int>();

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            availableSpawns.Add(i);
        }

        // Spawn do Player
        int playerSpawn = GetRandomSpawn(availableSpawns);
        Instantiate(playerPrefab,
                    spawnPoints[playerSpawn].position,
                    Quaternion.identity);

        // Spawn dos 3 Fantasmas
        for (int i = 0; i < 3; i++)
        {
            int ghostSpawn = GetRandomSpawn(availableSpawns);

            Instantiate(ghostPrefab,
                        spawnPoints[ghostSpawn].position,
                        Quaternion.identity);
        }
    }

    int GetRandomSpawn(List<int> availableSpawns)
    {
        int randomIndex = Random.Range(0, availableSpawns.Count);
        int spawnIndex = availableSpawns[randomIndex];

        // Remove para não repetir
        availableSpawns.RemoveAt(randomIndex);

        return spawnIndex;
    }
}