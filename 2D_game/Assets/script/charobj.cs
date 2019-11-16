using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charobj : MonoBehaviour
{
    [Header("跳躍高度"),Range(0,1000)]
    public int  height = 200;
    [Header("是否活著")]
    public bool alive = true; 

    public Transform character;

    private void Start() {
        print(character.position);
    }

    private void Update() {
       Jump();
    }

    ///<summary>
    ///角色跳躍
    ///</summary>
    private void Jump(){
         if (Input.anyKeyDown){
            Debug.Log("A key or mouse click has been detected");
            character.Translate(0,height*Time.deltaTime,0);
        }
    }

    ///<summary>
    ///角色死亡
    ///</summary>
    private void Dead(){
         
    }
}
