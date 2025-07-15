using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public static GManager instance = null;

    //プレイヤーのHP関連
    public int HP;
    [Header("最大HP")] public float MaxHP;
    [Header("HP割合")] public float wariai;

    private AudioSource audioSource = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Update()
    {

    }

    public void PlaySE(AudioClip clip)
    {
        if(audioSource != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}
