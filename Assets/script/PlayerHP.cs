using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    private Text hpText = null;
    private int oldHP = 0;

    // Start is called before the first frame update
    void Start()
    {
        hpText = GetComponent<Text>();
        if (GManager.instance != null)
        {
            hpText.text = "HP " + GManager.instance.HP;
        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(oldHP != GManager.instance.HP)
        {
            hpText.text = "HP " + GManager.instance.HP;
            oldHP = GManager.instance.HP;
        }
    }
}
