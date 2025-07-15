using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("�e�̈ړ����x")] public float speed;

    private bool isblock = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
  
        if (isblock)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    // �����蔻�肪����������Ă΂�郁�\�b�h
    public void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isblock = true;

        }
        if (collision.gameObject.CompareTag("enemy"))
        {
            isblock = true;

        }
    }
}
