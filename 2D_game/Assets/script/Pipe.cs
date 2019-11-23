using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : ground //繼承：可用繼承類別的成員
{
    /*
     * private void Start() {
        //刪除(物件,隔幾秒刪除)
        //gameObject 此類別的物件
        Destroy(gameObject,3.0f);
    }
    */
    private void OnBecameInvisible()
    {
        //掛此類別物件須有：meshRenderer
        //當在攝影機畫面之外(Game and Sence)的時候被呼叫
        Destroy(gameObject, 2.0f);
    }
}
