using UnityEngine;

public class PointsCollect : MonoBehaviour
 {
    public UIManager playerFruits;
    
    void OnTriggerEnter2D(Collider2D col){

        if(col.CompareTag("Player")){
            
            if (playerFruits != null)
            {
                playerFruits.AddFrutinha();
            }
            else
            {
                Debug.LogError("ta errrado ao");
            }
            // AudioManager.instanceSound.PlayFruitSound();
            // UIManager.playerScore = UIManager.playerScore + 50;
            // UIManager.playerFruits++;
            Destroy(gameObject);
        }

    }

}