using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("弾の移動速度")] public float speed;

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

    // 当たり判定が発生したら呼ばれるメソッド
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
