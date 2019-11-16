using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : ground //繼承：可用繼承類別的成員
{
    private void Start() {
        //刪除(物件,隔幾秒刪除)
        //gameObject 此類別的物件
        Destroy(gameObject,1.5f);
    }
}
