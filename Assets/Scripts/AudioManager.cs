using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public static AudioManager instanceSound;
    public AudioSource soundsSource;
    public AudioClip soundPointCollect;
    public AudioClip soundFruitCollect;

    void Awake()
    {

        if (instanceSound == null){

            instanceSound = this;
            DontDestroyOnLoad(gameObject);

        }else{

            Destroy(gameObject);

        }
    }

    public void PlayPointSound()
    {

        soundsSource.PlayOneShot(soundPointCollect);

    }

    public void PlayFruitSound()
    {

        soundsSource.PlayOneShot(soundFruitCollect);

    }

}