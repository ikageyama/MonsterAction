using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [Header("スピード")] public float speed;
    [Header("ダメージ")] public int Damage1;
    [Header("ジャンプカウント")] public float Jcount;

    //HPバー
    [SerializeField] private Healthbar m_healthbar;

    private string enemyTag = "enemy";
    public GroundCheck ground;//設置判定
    public GroundCheck head;

    private Animator anim = null;
    private Rigidbody2D rb = null;
    private bool isGround = false;
    private bool isJump = false;
    private bool isHead = false;
    private bool isDown = false;
    private bool D_jump = false;

    private bool isfinish = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        GManager.instance.HP = 150;
    }

    // Update is called once per frame
    void Update()
    {
        GManager.instance.wariai = GManager.instance.HP / GManager.instance.MaxHP;
        m_healthbar.SetSize(GManager.instance.wariai);

        Jcount += Time.deltaTime;
        if (!isDown)
        {
            //設置判定を得る
            isGround = ground.IsGround();
            isHead = head.IsGround();

            float horizontalKey = Input.GetAxis("Horizontal");

            if (horizontalKey > 0)
            {
                transform.localScale = new Vector3(-2, 2, 2);
                anim.SetBool("run", true);
                transform.Translate(Vector2.right * Time.deltaTime * speed);
            }
            else if (horizontalKey < 0)
            {
                transform.localScale = new Vector3(2, 2, 2);
                anim.SetBool("run", true);
                transform.Translate(Vector2.right * Time.deltaTime * -speed);
            }
            else
            {
                anim.SetBool("run", false);
            }

            if (Jcount > 1)
            {
                if (Input.GetKey(KeyCode.Space) && isGround) { 
                    isJump = true;
                    rb.AddForce(new Vector2(0, 13),ForceMode2D.Impulse);
                    Jcount = 0;
                }

            }

            if (rb.velocity.y < 0)
            {
                isJump = false;
            }

            anim.SetBool("jump", isJump);
            anim.SetBool("ground", isGround);
        }

        if(GManager.instance.HP <= 0)
        {
            isDown = true;
            anim.Play("player_down");
        }

        if (isfinish)
        {
            SceneManager.LoadScene("finishScene");
        }

    }

    //敵との接触判定
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == enemyTag)
        {
            GManager.instance.HP -= Damage1;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("goal"))
        {
            isfinish = true;

        }
    }
}
