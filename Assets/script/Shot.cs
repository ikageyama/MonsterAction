using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;//�e�̃v���n�u���w�肷��
    private float count;
    [Header("�W�����v���鎞�ɖ炷SE")] public AudioClip mahouSE;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if (Input.GetKey(KeyCode.F))
        {
            if (count >= 2)
            {
                GManager.instance.PlaySE(mahouSE);
                Instantiate(bulletPrefab, transform.position, transform.localScale.x < 0 ? 
                    Quaternion.Euler(0,0,0) : Quaternion.Euler(180,0,180));
                count = 0;
            }
        }
    }
}
