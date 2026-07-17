using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject canva_derrota_tempo;
    public static bool Gameover = false;
    public GameObject canva_vitoria;
    public UIManager UI;
    public GameObject CanvaMorte;
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

            Gameover = true;
            canva_vitoria.SetActive(true);
        }

        if(player.Vida <= 0){

            Gameover = true;
            canva_morte.SetActive(true);
        }

        if(UI.gameTimer <= 0){

            Gameover = true;
            canva_derrota_tempo.SetActive(true);
        }
        if(player.Vida <= 0){

            CanvaMorte.SetActive(true);
        }
    }
    
}
