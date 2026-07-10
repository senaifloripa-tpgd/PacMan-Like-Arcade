using UnityEngine;
using UnityEngine.SceneManagement;

public class trocacena : MonoBehaviour
{
    public int Cena;
    // Start is called once before the first execution of Update after the MonoBehaviour is created 
    void Start()
    {
        
    }

    public void TrocaCena()
    {
        SceneManager.LoadScene(Cena);
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
