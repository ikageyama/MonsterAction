using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    private bool finishPush = false;

    [SerializeField] GameObject operationCanvas;
    //�X�^�[�g�{�^�����Ă΂ꂽ�牟�����
   public void PressStart()
   {
        if (!finishPush)
        {
            SceneManager.LoadScene("PlayScene");
            finishPush = true;
        }
   }
   //�����ꂽ��Q�[�����I������
   public void PressExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                  Application.Quit();
#endif
    }
    //�����ꂽ�瑀�������\������
    public void PressOperation()
    {
        operationCanvas.SetActive(true);
    }
    //������������
    public void CloseOperation()
    {
        operationCanvas.SetActive(false);
    }
}
