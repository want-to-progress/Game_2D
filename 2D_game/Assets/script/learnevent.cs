using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnevent : MonoBehaviour
{
    
    public int count = 0;
    private void Start() {
        //遊戲開始的初始設定(初始金幣、血量)
        //print("Hello world"); //print in unity concle

    }
    
    private void Update() {
        count++;
        //print(count);

        //wrong declaration
        //public int a; 
        //we can not have a public var inside a private function
        //it is not make sense
    }
}
