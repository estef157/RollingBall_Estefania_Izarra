using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource sfx;
    
    public void  ReproducirSonido(AudioClip clip)
    {
        
        sfx.PlayOneShot(clip);
    }

    
}
