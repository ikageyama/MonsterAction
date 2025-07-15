using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1HPbar : MonoBehaviour
{
    [SerializeField] private Healthbar m_healthbar;
    [SerializeField] private Enemy1 e1;
    [Header("ìG1ç≈ëÂHP")] public float MaxHP;
    [Header("ìG1HPäÑçá")] public float wariai;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        wariai = e1.HP / MaxHP;
        m_healthbar.SetSize(wariai);
    }
}
