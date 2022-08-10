using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] GameObject audioPrefab;
    [SerializeField] int audioCount;
    List<GameObject> mp;
    Transform mainCamera;

    
    void Start()
    {
        instance = this;
        mp = new List<GameObject>();
        CreateNewMemory();
        mainCamera = Camera.main.transform;       
    }

    void CreateNewMemory()
    {
        for (int i = 0; i < audioCount; i++)
        {
            GameObject go = Instantiate(audioPrefab, transform);
            go.GetComponent<AudioSourceController>().Init(transform);
            mp.Add(go);
            go.SetActive(false);
        }
    }
    GameObject Obj()
    {
        for (int i = 0; i < mp.Count; i++)
        {
            if (!mp[i].activeSelf)
                return mp[i];         
        }
        CreateNewMemory();
        return Obj();           
    }
    public void PlayAudioClip(AudioClip AudioSource,Transform tr=null)
    {
        if (AudioSource == null)
            return;
        tr = (tr == null) ?  mainCamera: tr;
        
        GameObject gameObj=Obj();
        gameObj.GetComponent<AudioSourceController>().SetAudio(AudioSource, tr);
    }
    
}
