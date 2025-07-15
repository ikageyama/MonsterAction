using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [Header("�ړ����x")] public float speed;
    [Header("�d��")] public float gravity;
    [Header("�̗�")] public int HP;
    [Header("����")] public float count;
    [Header("�ڐG����")] public EnemyCollisionCheck checkCollision;
    private string bulletTag = "bullet";

    //�v���C�x�[�g�ϐ�
    private SpriteRenderer sr = null;
    private Rigidbody2D rb = null;
    private Animator anim = null;
    private bool rigjtTleftF = false;
    private bool isblock = false;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count += Time.deltaTime;
        if (sr.isVisible)
        {
            if (checkCollision.isOn || isblock)
            {
                rigjtTleftF = !rigjtTleftF;
                isblock = false;
            }
            int xVector = -1;
            if (rigjtTleftF)
            {
                xVector = 1;
                transform.localScale = new Vector3(-2, 2, 2);
            }
            else
            {
                transform.localScale = new Vector3(2, 2, 2);
            }
            rb.velocity = new Vector2(xVector * speed, -gravity);
        }
        else
        {
            rb.Sleep();
        }

        if (HP < 0)
        {
            Destroy(gameObject);
        }

    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("block"))
        {
            isblock = true;
            
        }

        if (collision.gameObject.CompareTag(bulletTag))
        {
            if (count > 1)
            {
                HP -= 50;
                count = 0;
            }
        }
    }
}
