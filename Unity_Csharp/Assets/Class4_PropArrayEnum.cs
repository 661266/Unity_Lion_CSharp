using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//定義列舉
//定義在類別外可以讓所有類別使用
public enum Season
{
    Spring,Summer,Fall,Winter
}


public enum State
{
    Idle,Walk,Attack,Damage,Skill,Dead
}
public enum Day
{
    Sumday = 7,Monday =1,Tuesday,Wensday,Thursday,Friday,Saturday
}


public class Class4_PropArrayEnum : MonoBehaviour   //類別
{

    //使用列舉
    //修飾詞 列舉名稱 自訂名稱
    public Season _season;
    public State _state;    
    public Day _day= Day.Wensday;

    public void Awake()
    {
        //取得列舉
        print("季節:" + _season);
        print("狀態:" + (int)_state);
        print("星期:" + (int)_day);
        //存取c列舉 
        _state = State.Walk;

    }


    public Ship ship;

    //一般欄位
    public string name1 = "YA";
    public string name2 = "SA";
    public string name3 = "YASA";

    //陣列:類型[]
    //屬性面板上 size 指的是數量
    //屬性面板上Element 為陣列成員 編號從0開始
    public string[] names;                               //宣告陣列不指定數量

    public float[] weights = new float[3];               //宣告陣列並指定數量

    public int[] scones = new int[] { 10, 20, 50, 90 };  //宣告陣列並指定內容

    public bool[] mission = { true, false, false };      //宣告陣列並指定內容 ※通常用這個※



    private void Start()
    {
        //設定屬性
        ship.length = 99.9f;
        //取得屬性
        print("船的寬度:" + ship.length);

        //設定唯獨屬性
        //ship.width = 20.5f錯誤
        //取得屬性欄位
        print("船的寬度:" + ship.width);

        ship.atk = 50.3f;
        print("船的攻擊力" + ship.atk);

        //指定陣列資料
        names = new string[] { "怪物A", "怪物B", "怪物C" };

        //陣列存取
        scones[0] = 77;
        //陣列取得

        print("取得怪物陣列第三筆資料:" + names[2]);
        //錯誤示範 print("取得怪物陣列第三筆資料:" + names[3]); 
        //IndexOutOfRangeException: 代表超出資料數量 我們這邊只有4筆資料 0123

        //陣列.Length 長度(數量)
        print("分數陣列的長度(數量):" + scones.Length);


        //呼叫改變分數方法並將分數陣列傳進方法內
        ChangeScore(scones);
        TestValue(A);
        TestRefe(B);



    }


    /// <summary>
    /// 改變第二筆分數為99分
    /// </summary>
    /// <param name="theArray"></param>
    public void ChangeScore(int[] theArray)

    {
        theArray[1] = 99;

    }

    //整數為實質型別
    public int A = 99;
    //陣列為參考型別
    public int[] B = { 99 };

    /// <summary>
    /// 測試實值型別:傳遞 - 傳資料夾,不會修改原資料
    /// </summary>
    /// <param name="text"></param>
    private void TestValue(int text)
    {
        text = 0;
    }

    /// <summary>
    /// 測試參考型別:傳址 - 傳地址進來，會修改原本資料
    /// </summary>
    /// <param name="text"></param>

    private void TestRefe(int[] text)
    {
        text[0] = 0;
    }






}
