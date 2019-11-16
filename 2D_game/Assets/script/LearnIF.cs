using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnIF : MonoBehaviour
{
    public bool test;
    public string prop;

    [Header("血量"),Range(0,100)]
    public int HP = 100;

    //60fps
    private void Update(){
        if (test)
        {
            print("打開開關~");
        }
        else{
            print("關閉開關~");
        }

        /*
        #region prop
        if (prop == "紅色藥水")
        {
            print("補血");
        }
        else if (prop == "藍色藥水")
        {
            print("補魔力");
        }
        else if (prop == "黃色藥水")
        {
            print("補體力");
        }
        else{
            print("沒事情發生~~");
        }
        #endregion
        */
        if(HP >= 70)       print("安全");
        else if(HP >= 50)  print("警告");
        else if(HP >= 20)  print("危險");
        else if(HP > 0)    print("快死了");
        else               print("死了");
    }
}
