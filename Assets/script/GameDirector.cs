using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    [SerializeField] private Healthbar m_healthbar;
    // Start is called before the first frame update
    void Start()
    {
        m_healthbar.SetSize(0.5f);
    }

}
