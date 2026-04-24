using UnityEngine;

public class PointsCollect : MonoBehaviour
 {
  
    void OnTriggerEnter2D(Collider2D col){

        if(col.CompareTag("Player")){

            AudioManager.instanceSound.PlayFruitSound();
            UIManager.playerScore = UIManager.playerScore + 50;
            UIManager.playerFruits++;
            Destroy(gameObject);

        }

    }

}