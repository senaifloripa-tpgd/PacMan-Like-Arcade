using UnityEngine;
using System.Collections;
using TMPro;
public class UIManager : MonoBehaviour
{

    public int gameTimer = 60;
    public int playerFruits = 0;
    public int playerScore = 0;
    public int playerFrutona = 0;
    public TextMeshProUGUI FrutonaText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI fruitsText;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        GameManager.Gameover = false;
        StartCoroutine(TimerCount());
    }

    void Update()
    {
    }

    IEnumerator TimerCount()
{
    while (gameTimer >= 0 && !GameManager.Gameover)
    {
        timerText.text = "TIME: " + gameTimer.ToString();
        yield return new WaitForSeconds(1f);
        gameTimer--;

        if (gameTimer <= 10)
        {
            timerText.color = new Color32(238, 72, 72, 255);
        }
    }
}

    public int AddFrutas(int qtd)
    {
        playerFrutona += qtd;
        
         
        if (playerFrutona >= 3)
        {   
            Debug.Log("Canva erro");
            canva_vitoria.SetActive(true); 
        }
        return playerFrutona;
    }


    public void AddFrutinha()
    {
        playerFruits++;
    }   
}