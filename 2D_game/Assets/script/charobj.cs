using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charobj : MonoBehaviour
{
    #region declaration
    [Header("跳躍高度"),Range(0,500)]
    public int  height = 300;
    [Header("是否活著")]
    public bool alive = true;
    [Header("剛體")]
    public Rigidbody2D character;
    [Header("旋轉角度"), Range(0, 20)]
    public float angle = 6;

    public GameObject showScore, showGM;

    [Header("GM")]
    public GameManager gm;
    
    
    public AudioSource aud;
    [Header("跳躍音效")]
    public AudioClip jump;
    [Header("加分音效")]
    public AudioClip add;
    [Header("死亡音效")]
    public AudioClip dead;
    #endregion

    private void Start() {
        //print(character.position);
        alive = true;
    }

    //固定幀數
    private void Update() {
        IsGameStart();
        Jump();
    }

    #region function
    //遊戲是否開始
    private void IsGameStart()
    {
        if (!Input.GetKeyDown(KeyCode.Mouse0)) return;
        showScore.SetActive(true);
        showGM.SetActive(true);
    }

    ///<summary>
    ///角色跳躍
    ///</summary>
    private void Jump(){

        if (!alive) return; //死亡則不執行

        //玩家按下左鍵，小雞往上跳
        if (Input.GetKeyDown(KeyCode.Mouse0)){
            character.Sleep(); //reset rigidbody
            character.gravityScale = 1.0f;
            character.AddForce(new Vector2(0.0f, height));

            //播放一次
            aud.PlayOneShot(jump, 1.5f);
        }
        //SetRotation(rotate_degree)
        //character.velocity.y --> get velocity y
        character.SetRotation(angle * character.velocity.y);
        
       
    }

    //碰撞開始時，執行一次
    //存放碰到物件的資訊
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print(collision.gameObject.name); //把撞到的東西印出來
        if(collision.gameObject.name == "06_地板")
        Dead();
    }

    //碰撞且有勾選Is Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "水管_上" || collision.gameObject.name == "水管_下") Dead();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "加分判定" && alive) //活著才加分
        {
            gm.AddScore();
            aud.PlayOneShot(add, 1.5f);
        }
    }

    ///<summary>
    ///角色死亡
    ///</summary>
    private void Dead(){
        aud.PlayOneShot(dead, 1.5f);
        //print("死亡!!!!");
        alive = false;
        gm.Game_over();
    }
    #endregion
}