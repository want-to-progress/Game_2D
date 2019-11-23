//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    #region declaration
    public float speed = 3; //moving ground speed
    private float init_pos_x;
    //want to control the position
    public Transform floor;
    #endregion
    private void Start() {
        //print(floor.position);
        init_pos_x = floor.position.x;
    }

    private void Update() {
      Move();
    }
    #region function
    /// <summary>
    /// (在快捷選單上加上註解)
    /// 地板移動
    /// </summary>
    private void Move(){
        if (GameManager.gameOver) return; //如果gameover，地板就不會移動
    //we can not do this
    //floor.position.x++;
    
    //transformObject.Translate(float x,float y, float z);
    //move the floor to the left
        floor.Translate(-speed *Time.deltaTime,0,0);
    //it means x = x - speed 
    //Time.deltaTime --> 每幀的時間
    /*
      Normalize
      Time.deltaTime = 1/frequence(Hz);
      user A  60Hz * speed * Time.deltaTime = speed
      user B  10Hz * speed * Time.deltaTime = speed
    */
     //print(floor.position);
    }
    #endregion
}
