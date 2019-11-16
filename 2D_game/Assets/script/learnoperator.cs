using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnoperator : MonoBehaviour
{
    public int a = 10,b = 3,score;
    public int num1 = 0x000F,num2 = 0x0004;
    public bool B1=true, B2=false;
    public int[] pointer;

    private void Start() {
        //摺疊程式碼
        #region folder 
        print(a+b); 
        print(a-b);
        print(a*b);
        print(a/b);
        print(a%b);
        #endregion

        print(a++);
        //it means
        //print(a);
        //a = a + 1;

        #region bool_operator
        score += 10;
        //score = score + 10;
        //= is right associate
        //+ is left associate 
        //等號右邊加完再給左邊

        print(b>10); // False
        print(B1 && B2); // flase   (and)
        print(B1 || B2); // true    (or)
        print(num1 & num2); // 4    (bitwise and)
        print(num1 | num2); // 15   (bitwise or)
        print(!B1); // flase        (not)
        print(~num1);//0xFFF0 = -16 (bitwise not 2's complement)
        #endregion

        pointer = new int [10]; //dynamic memory
    }

}