using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charobj : MonoBehaviour
{
    [Header("跳躍高度"),Range(0,1000)]
    public int  height = 300;
    [Header("是否活著")]
    public bool alive = true; 
    [Header("剛體")]
    public Rigidbody2D character;
    [Header("旋轉角度"), Range(0, 20)]
    public float angle = 6;

    public GameObject showScore, showGM;

    private void Start() {
        print(character.position);
    }

    //固定幀數
    private void FixedUpdate() {
        IsGameStart();
        Jump();
    }

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
        }
        //SetRotation(rotate_degree)
        //character.velocity.y --> get velocity y
        character.SetRotation(angle * character.velocity.y);
    }

    //碰撞開始時，執行一次
    //存放碰到物件的資訊
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name); //把撞到的東西印出來
        Dead();
    }

    ///<summary>
    ///角色死亡
    ///</summary>
    private void Dead(){
        print("死亡!!!!");
        alive = false;
    }
}
