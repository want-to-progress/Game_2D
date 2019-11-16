using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前分數")]
    public int current_point = 0;

    public int highest_score = 0;
    private void Start() {
        
    }

    ///<summary>
    ///加分
    ///</summary>
    public void AddScore(){

    }

    //只有GameManager這個class才能使用
    ///<summary>
    /// 最高分數判定
    ///</summary>
    private void Best_score(){

    }

    ///<summary>
    ///生成水管
    ///</summary>
    private void Generate_pipe(){

    }

    ///<summary>
    ///遊戲失敗
    ///</summary>
    public void Game_over(){

    }
}
