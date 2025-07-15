using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    [Header("ƒ^ƒCƒgƒ‹‚Ö‚Ì‘JˆÚŽžŠÔ")] public float count;
    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (count > 3)
        {
            SceneManager.LoadScene("titleScene");
            count = 0;
        }
    }
}
