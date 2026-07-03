using UnityEngine;

public class Frutona : MonoBehaviour
{

    public UIManager playerFrutona;

    void OnTriggerEnter2D(Collider2D col)
    {

        if(col.CompareTag("Player"))
        {

            Destroy(gameObject);

            playerFrutona.AddFrutas(1);
        }
    }
    
}
