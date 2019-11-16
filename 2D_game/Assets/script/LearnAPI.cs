using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    /*
        structure of a Project
        1.class
        2.field & properties
        3.Method
     */
    //欄位
    public Transform TransformA;
    public Camera C;
    public AudioSource Music;
    private void Start() {
        #region static-member
         //use a static member(field & properties) in a class
         print("隨機:" + Random.value);

         print("PI:" + Mathf.PI);

         //use a static member(method) in a class
         print("隨機範圍:" + Random.Range(0,100));
         print(Mathf.Abs(-10));
        #endregion

         //use a non-static member in a class
         //需要先給予欄位存放實體物件
        print("物件A座標:" + TransformA.position); //unity 內部拉取欄位
       
        TransformA.position =  new Vector3(-2,0,0);//character postiion
        
        print("相機深度:" + C.depth);

        Music.mute = true;
    }

    private void Update() {
        TransformA.Rotate(10,0,0);
    }
}
