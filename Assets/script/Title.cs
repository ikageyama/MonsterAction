using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    private bool finishPush = false;

    [SerializeField] GameObject operationCanvas;
    //スタートボタンを呼ばれたら押される
   public void PressStart()
   {
        if (!finishPush)
        {
            SceneManager.LoadScene("PlayScene");
            finishPush = true;
        }
   }
   //押されたらゲームを終了する
   public void PressExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                  Application.Quit();
#endif
    }
    //押されたら操作説明を表示する
    public void PressOperation()
    {
        operationCanvas.SetActive(true);
    }
    //操作説明を閉じる
    public void CloseOperation()
    {
        operationCanvas.SetActive(false);
    }
}
