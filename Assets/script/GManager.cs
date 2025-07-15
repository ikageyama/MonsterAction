using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public static GManager instance = null;

    //�v���C���[��HP�֘A
    public int HP;
    [Header("�ő�HP")] public float MaxHP;
    [Header("HP����")] public float wariai;

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
