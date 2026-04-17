using UnityEngine;

public class SpawnManegent : MonoBehaviour
{

    public Transform[] playersSpawnPoints;
    public Transform[] fruitSpawnPoints;
    public GameObject playerPrefab;
    public GameObject[] ghostsPrefabs;
    public GameObject fruitPrefab;
    private int playerPos;
    private int ghostCount = 0;
    private int randFruit;
    private bool repeatedFruit;
    public int[] fruitPos = new int[5];

    void Start()
    {

        SpawnPlayers();
        SpawnFruits();
        
    }

    void SpawnPlayers(){

        playerPos = Random.Range(0,4);

        for(int i=0; i < playersSpawnPoints.Length; i++){

            if(i != playerPos){

                Instantiate(ghostsPrefabs[ghostCount], playersSpawnPoints[i]);
                ghostCount++;

            }else{

                Instantiate(playerPrefab, playersSpawnPoints[i]);

            }

        }

    }

    void SpawnFruits(){

        for (int i = 0; i < fruitPos.Length; i++)
        {

            do{            
                
                repeatedFruit = false;
                randFruit = Random.Range(0, 10);

                for (int j=0; j < i; j++)
                {
                    if (fruitPos[j] == randFruit)
                    {
                        repeatedFruit = true;
                        break;
                    }
                }

            } while (repeatedFruit);

            fruitPos[i] = randFruit;
            Instantiate(fruitPrefab, fruitSpawnPoints[randFruit]);
        }

    }

}