//gjord av Theo
using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManeger : MonoBehaviour
{

    public Sound[] sound; // ansluter till scripted Sound
    public static AudioManeger instance;


    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
        }
        

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sound) 
        {

            s.source = gameObject.AddComponent<AudioSource>(); // g�r s� att man kan referera till audiomaneger 
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }

    }

    private void Start()
    {
        Sound s = Array.Find(sound, sound => sound.name == "Theme");// hitatr theme i b�rjan 
        if (s.source.isPlaying == false)
        {
            Play("Theme");// spelar theme om den int spelas 
        }
        
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sound, sound => sound.name == name); // g�r der m�jligt att hitta ljudet som man vill spela och spelar det
        s.source.Play();
    }

}

