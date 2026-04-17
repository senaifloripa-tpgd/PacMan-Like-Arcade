using UnityEngine;
using System.Collections;
using TMPro;
public class UIManager : MonoBehaviour
{

    public static int gameTimer = 60;
    public static int playerFruits = 0;
    public static int playerScore = 0;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI fruitsText;
    public TextMeshProUGUI scoreText;

    void Start()
    {

        StartCoroutine(TimerCount());
        
    }

    void Update()
    {

        fruitsText.text = "FRUITS: " + playerFruits.ToString();
        scoreText.text = "SCORE: " + playerScore.ToString();
        
    }

    IEnumerator TimerCount(){

        while (gameTimer >= 0)
        {
            timerText.text = "TIME: " + gameTimer.ToString();
            yield return new WaitForSeconds(1f);
            gameTimer--;

            if(gameTimer <= 10){

                timerText.color = new Color32(238, 72, 72, 255);

            }

        }

    }

}