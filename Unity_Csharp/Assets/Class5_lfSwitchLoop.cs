using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class5_lfSwitchLoop : MonoBehaviour
{
    [Header("是否開門")]
    public bool openDoor;
    [Header("分數")]
    public int score;
    [Header("血量"), Range(0, 100)]
    public int hp = 100;
    [Header("道具")]
    public string prop = "紅水";

    public Season season;

    [Header("道具數量")]
    public int count;
    [Header("任務是否完成")]
    public bool complete;

    public string test;
    private int i = 1;
    private int j = 1;

    //GameObject 可存放階層面板或專案內的模型
    [Header("地板")]
    public GameObject cube;

    public int[] scores = { 100, 99, 88, 77, 66, 55 };

   
    private void CreateFloor (int length,int width)
        //異狀迴圈
        //注意初始值名稱不能相同
        {
        for (int j = 0; j < width; j++)
        {
            for (int i = 0; i < length; i++)
            {
                //API實例化 (生成)
                //生成(物件,座標,角度)
                //Vector3 三維向量(可保存3個浮點數)
                //Quaternion 角度 x,y,z,w
                //Quaternion.identity 零角度
                //Quaternion.Euler(x,y,z) 歐拉角度 - 0~360度
                Instantiate(cube, new Vector3(j * 2, 0, i * 2), Quaternion.Euler(270, 0, 0));
            }
        }

}

    private void Awake()
    {
        CreateFloor(30, 5);

        //while迴圈
        //while (布林值) {當布林值為true 執行}
        //while迴圈之前評估:第一次判斷 i = 1

        while (i <= 10)
        {
            print("while 迴圈第:" + i + "次");
            i++;
        }

        //do迴圈之後評估
        do
        {
            print("do 迴圈第:" + j + "次");
            j++;
        } while (j <= 10);

        for (int k = 0; k < 10; k++)
        {
            print("for 迴圈第:" + k + "次");
        }

        for (int k = 10; k > 0; k--)
        {
            print("for 迴圈倒數:" + k + "次");
        }
        /* for (int i = 0; i < 101; i++)
         {
             print("break 迴圈:" + 1);
             //如果i等於10就打斷迴圈並且執行迴圈下方的程式
             if (i == 10) break;
             { 

             }
             print("for 迴圈外的程式:" );

         }
         */
        /* for (int i = 0; i < 101; i++)
         {
             print("return 迴圈:" + 1);
             //如果i等於10就跳出方法外，下方程式皆不執行
             if (i == 10) return;
             {

             }
             print("return 迴圈外的程式:");

         }
         */

        /*//執行結果: 0-4 6-19 迴圈外的程式
        for (int i = 0; i < 20; i++)
        {
            if (i == 5) continue;
            {
                print("continue 迴圈:" + i);
            }
            print("continue 迴圈外的程式:");

        }*/
        for (int i = 0; i < 10; i++)
        {
            //goto標記陳述式
            if (i == 5) goto Test;
            {
                print("goto迴圈第:" + i);
            }
        //標記陳述式
             Test:
            //標記陳述式
            print("這是標記陳述式");
        }





    }

    public void Start()
    {
        //if 判斷式
        //if (布林值) {布林值 = true 時執行}
        if (true)
        {
            print("哈囉,我是 if 判斷式");
        }
    }

    //更新事件:一秒執行約60次 (60 FPS)
    private void Update()
    {


        //當道具數量 >=5 任務完成 true
        //三元運算子語法 - 布林運算式 ?  運算式:a  運算式:b
        //指派、呼叫 = ()
        complete = (count >= 5) ? true : false;

        /*//利用判斷式 if 方法寫法
        if (count >=5)
        {
            complete = true;
        }
        else
        {
            complete = false;
        }
        */

        switch (prop)
        {
            case "紅水":
                print("補 HP~");
                break;
            case "藍水":
                print("補 MP~");
                break;
            case "黃水":
                print("補 TP~");
                break;
            //default: 是只上述都不符合，也可省略
            default:
                print("你吃錯藥了");
                break;
        }

        switch (season)
        {
            case Season.Spring:
                print("春");
                break;
            case Season.Summer:
                print("夏");
                break;
            case Season.Fall:
                print("秋");
                break;
            case Season.Winter:
                print("冬");
                break;

        }




        //當openDoor 為 ture 執行 (開門)
        //當openDoor 為 false 執行 (關門)
        //if (openDoor == ture)
        if (openDoor)
         {
             print("開門~");
         }
         else
         {
             print("關門~");
         }

         //大於等於 60及格
         //小於 60被當
         if (score >= 60)
         {
             print("及格");
         }
         else if (score >= 40)
         {
             print("補考~");
         }
         else if (score >= 20)
         {
             print("付錢拉~");
         }
         else 
         {
             print("滾");
         }

     
         //HP 寫的地方
        if (hp >70)
        {
            print("安全");
        }

        else if (hp >= 70) 
        {
            print("警告");
        }
        else if (hp >= 20)
        {
            print("危險");
        }
        else
        {
            print("你要死了");
        }


        


        //使用for迴圈取得陣列資料
        for (int i = 0; i < scores.Length; i++)
        {
            print("for 迴圈取得資料:" + scores[i]);
        }

        //foreach迴圈取得陣列資料
        //語法:foreach(取得資料類型 取得資料的名稱 in陣列) {執行次數為陣列數量}
        foreach (int item in scores)
        {
            print("foreach 迴圈取得資料:" + item);

        }

       

    }

    }

