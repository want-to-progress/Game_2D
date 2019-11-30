using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // change text
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region declaration
    [Header("目前分數")]
    public int current_point = 0;
    [Header("歷史最高分")]
    public int highest_score = 0;
    [Header("水管")]

    //GameObject 可存放場景上的遊戲物件及專案內的預製物
    public GameObject pipe;

    [Header("遊戲結算畫面")]
    public GameObject showRank;

    //static不會顯示在屬性面板(inspector)上
    public static bool gameOver = false;
    [Header("記分板")]
    public Text score;
    [Header("最佳分數")]
    public Text Highscore;
    #endregion

    private void Start() {
        gameOver = false; //若replay，要從設定(還原)
        //InvokeRepeating(funct_name,start time, 隔多久再跑一次);
        InvokeRepeating("Generate_pipe",0,1.3f);

        //把"最佳分數"從記憶體拿出來
        Highscore.text = (PlayerPrefs.GetInt("最佳分數")).ToString();

        //修改螢幕解析度
        //SetResolution(width, height, is_full_screen);
        Screen.SetResolution(450, 800, false);
    }

    ///<summary>
    ///加分
    ///</summary>
    public void AddScore(){
        if (gameOver) return;
        //print("加分");
        ++current_point;
        //print(current_point);
        score.text = current_point.ToString(); //把分數轉成文字放到記分板上
    }

    //只有GameManager這個class才能使用
    ///<summary>
    /// 最高分數判定，更新最高分數
    ///</summary>
    private void Best_score(){
        if(current_point > PlayerPrefs.GetInt("最佳分數")){
            Highscore.text = current_point.ToString();
            //把"最佳分數"的資料換成current_point
            PlayerPrefs.SetInt("最佳分數",current_point);
        }
    }

    ///<summary>
    ///生成水管
    ///</summary>
    private void Generate_pipe(){
        //print("生水管~~");
        //生成(物件)
        //Object.Instantiate(pipe);
        
        //生成(物件,座標、角度)
        //區域欄位 不需public
        Vector3 pos = new Vector3(3,Random.Range(-0.5f,2.5f),0);
        Object.Instantiate(pipe,pos,Quaternion.identity);
    }

    ///<summary>
    ///遊戲失敗
    ///</summary>
    public void Game_over(){
        showRank.SetActive(true);
        gameOver = true;
        CancelInvoke("Generate_pipe");   //停止生成(InvokeRepeating)


        Best_score();
    }

    //要給UI按鈕呼叫的方法必須是public
    /// <summary>
    /// 重新開始
    /// </summary>
    public void replay()
    {
        
        //Application.LoadLevel("scene2D"); //載入場景(舊API)
        //有綠色底線-->取代成新版
        SceneManager.LoadScene("scene2D"); // LoadScrence(scence string, mode)
        //結束之後從Start開始
    }

    public void quit()
    {
        Application.Quit();
    }
}
