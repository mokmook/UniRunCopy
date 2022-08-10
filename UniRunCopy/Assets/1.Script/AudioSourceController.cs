using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceController : MonoBehaviour
{
    AudioSource audioSource;
    Transform audioManagerTr;
   
    public AudioSourceController Init(Transform Tr)
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioManagerTr = Tr;
        return this;
    }
    public void SetAudio(AudioClip aClip,Transform tr)
    {
        audioSource.clip = aClip;
        gameObject.transform.SetParent(tr);
        gameObject.SetActive(true);
        audioSource.Play();

        Invoke("ActiveFalse", aClip.length);
    }
    void ActiveFalse()
    {
        audioSource.clip = null;
        gameObject.transform.SetParent(audioManagerTr);
        gameObject.SetActive(false);
    }
}
