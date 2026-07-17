using UnityEngine;
using UnityEngine.SceneManagement;

public class trocacena : MonoBehaviour
{
    public int Cena;
    public void TrocaCena()
    {
        SceneManager.LoadScene(Cena);
    }
    
