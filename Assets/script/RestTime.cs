using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class RestTime : MonoBehaviour
{
    private Text timeText = null;
    [Header("ŽžŠÔ")]public float time;
    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<Text>();
        timeText.text = "Time: " + (int)time;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timeText.text = "Time: " + (int)time;

        if(time <= 0)
        {
            SceneManager.LoadScene("titleScene");
        }
    }
}
