using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charobj : MonoBehaviour
{
    [Header("跳躍高度"),Range(0,1000)]
    public int  height = 0;
    [Header("是否活著")]
    public bool alive = true; 
}
