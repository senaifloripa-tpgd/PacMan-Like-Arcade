using UnityEngine;

public class Frutona : MonoBehaviour
{

    public UIManager playerFrutona;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D col){

        if(col.CompareTag("Player")){

            // AudioManager.instanceSound.PlayFruitSound();
            // UIManager.playerScore = UIManager.playerScore + 50;
            // UIManager.playerFruits++;
            Destroy(gameObject);

            playerFrutona.AddFrutas(1);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}
