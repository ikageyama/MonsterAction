using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    [Header("�X�s�[�h")] public int speed;
    [Header("����")] public float count;
    public int xVector;
    private SpriteRenderer sr = null;
    private Rigidbody2D rb = null;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //���̓��쐧��
            count += Time.deltaTime;
            if (count <= 5)
            {
                xVector = -1;
            }

            if(count >= 5 && count < 10)
            {
                xVector = 1;
            }
            
            if(count > 10)
            {
                count = 0;
            }
            transform.Translate(Vector3.right * xVector * speed * Time.deltaTime);

    }
}