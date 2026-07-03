// using UnityEngine;

// // Esta classe é responsável por gerenciar onde os jogadores e frutas aparecem no jogo
// public class SpawnManagement : MonoBehaviour
// {
//     // Lista de lugares onde os jogadores podem aparecer
//     public Transform[] playersSpawnPoints;
    
//     // Lista de lugares onde as frutas podem aparecer
//     public Transform[] fruitSpawnPoints;
    
//     // Modelo do jogador que será colocado no jogo
//     public GameObject playerPrefab;
    
//     // Modelos dos fantasmas que podem aparecer
//     public GameObject[] ghostsPrefabs;
    
//     // Modelo da fruta que será colocada no jogo
//     public GameObject fruitPrefab;
    
//     // Variável para guardar a posição do jogador
//     private int playerPos;
    
//     // Contador para saber quantos fantasmas foram colocados
//     private int ghostCount = 0;
    
//     // Variável para escolher um lugar aleatório para a fruta
//     private int randFruit;
    
//     // Sinal que indica se a fruta já foi colocada em algum lugar
//     private bool repeatedFruit;
    
//     // Lista que guarda as posições das frutas
//     public int[] fruitPos = new int[5];

//     // Este método é chamado quando o jogo começa
//     void Start()
//     {
//         // Chamamos o método que coloca os jogadores
//         SpawnPlayers();
        
//         // Chamamos o método que coloca as frutas
//         SpawnFruits();
//     }

//     // Método que coloca os jogadores e fantasmas nos lugares
//     void SpawnPlayers()
//     {
//         // Escolhemos um lugar aleatório para o jogador aparecer
//         playerPos = Random.Range(0, 4);

//         // Olhamos todos os lugares onde os jogadores podem aparecer
//         for (int i = 0; i < playersSpawnPoints.Length; i++)
//         {
//             // Se não for o lugar do jogador
//             if (i != playerPos)
//             {
//                 // Colocamos um fantasma nesse lugar
//                 Instantiate(ghostsPrefabs[ghostCount], playersSpawnPoints[i]);
//                 ghostCount++; // Aumentamos o contador de fantasmas
//             }
//             else
//             {
//                 // Colocamos o jogador nesse lugar
//                 Instantiate(playerPrefab, playersSpawnPoints[i]);
//             }
//         }
//     }

//     // Método que coloca as frutas nos lugares
//     void SpawnFruits()
//     {
//         // Para cada fruta que queremos colocar
//         for (int i = 0; i < fruitPos.Length; i++)
//         {
//             do
//             {
//                 repeatedFruit = false; // Começamos dizendo que a fruta não foi repetida
//                 // Escolhemos um lugar aleatório para a fruta
//                 randFruit = Random.Range(0, 10);

//                 // Olhamos se já colocamos uma fruta nesse lugar
//                 for (int j = 0; j < i; j++)
//                 {
//                     // Se a fruta já estiver em algum lugar
//                     if (fruitPos[j] == randFruit)
//                     {
//                         repeatedFruit = true; // Marcamos que a fruta foi repetida
//                         break; // Saímos do loop
//                     }
//                 }

//             } while (repeatedFruit); // Continuamos escolhendo até encontrar um lugar novo

//             // Guardamos o lugar da fruta
//             fruitPos[i] = randFruit;
//             // Colocamos a fruta no lugar escolhido
//             Instantiate(fruitPrefab, fruitSpawnPoints[randFruit]);
//         }
//     }
// }