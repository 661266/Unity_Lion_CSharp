using UnityEngine;  //引用Unity API(函式庫:Unity，屬性，功能...)

//類別:Class 定義一個物件
//語法:Class 類別名稱
// : 可以將此腳本掛在 Unity 物件上
//類別必須放在物件上才能執行
public class Class1 : MonoBehaviour
{
    //定義類別成員
    //C#
    //1.大小不一樣(檔名也是)
    //2.括號包含: () {} [] "" '' <>

    //事件:在特定時間已指定次數執行的方法(藍色)
    //開始事件(Start):撥放遊戲時執行一次 - 初始設定 
    private void Start()
    {
        //輸出(print)("文字訊息")
        //C# 結尾為分號;
        print("嗨");
    }
}
