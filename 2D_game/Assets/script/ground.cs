//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
  public float speed = 3; //moving ground speed
  private float init_pos_x;
  //want to control the position
  public Transform floor;
  private void Start() {
    //print(floor.position);
    init_pos_x = floor.position.x;
  }

  private void Update() {
    Move();
    check_ground_region();
  }

  /// <summary>
  /// 在快捷選單上加上註解
  /// 確認地板範圍
  /// </summary>
  private void check_ground_region(){
    //if(floor.position.x < init_pos_x - 100) 
      //floor.Translate(100,0,0); //if run out of ground
  }

  /// <summary>
  /// 地板移動
  /// </summary>
  private void Move(){
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
}
