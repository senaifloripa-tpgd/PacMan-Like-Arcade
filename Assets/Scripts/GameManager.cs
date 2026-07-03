using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static bool isGameOver = false;
    public GameObject canva_derrota_tempo;
    public PlayerOneMove Vida;
    public GameObject canva_vitoria;
    public UIManager UI;
    public PlayerOneMove player;
    public GameObject canva_morte;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(UI.playerFrutona >= 3){

            canva_vitoria.SetActive(true);
        }

        if(player.Vida <= 0){

            Debug.Log("aqui");
            canva_morte.SetActive(true);
        }
        if(UI.gameTimer <= 0){

            canva_derrota_tempo.SetActive(true);
        }
    }
    
}
