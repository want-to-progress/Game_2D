using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnfield : MonoBehaviour
{
    //Field
    //int (default 0), float(default 0), string(default ""), bool(default false)
    [Header("等級")] //會顯示在inspector
    public int level = 1;
    [Tooltip("速度"),Range(0.1f,10.0f)]
    public float speed = 1.0f;
    public double x = 0.0;
    public string str = "哈";
    public bool mission_clear = true;
}
