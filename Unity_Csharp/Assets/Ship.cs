using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    //公開欄位:給任何人存取
    //從其他類別取得或存取資料
    public float speed = 20;

    //私人欄位:僅限於此類別存取
    //從其他類別無法取得或存取資料
    private float weight = 50;


    //問題:
    //假設需要取得但是不能修改 - 屬性 (權限)
    //屬性語法
    //修飾詞 類型 名稱 {存取權限}
    //get 可以取得 
    //set 可以存取
    //讀寫權限屬性
    //屬性不會顯示在面板上 (ODIN) - UnityEditor
    public float length { get; set; }

    //企劃:寬度固定 30不便
    //封裝欄位:
    //1.私人欄位
    //2.唯獨屬性 (return 私人欄位)
    public float _width = 30;
    //唯獨屬性:不能設定值
    public float width { get { return _width; } }

    //企劃:高度固定 10不便
    private float _height = 10.5f;

    // =>(黏巴達 Lembda)
    //C# 6板以上 | Unity 2017 C#7版
    //目前C# 改版 8 版
    //get => _height; 等同 get { return _heihgt; }
    public float height { get => _height; }

    private float lv = 3;

    //封裝欄位:
    //1.私人欄位
    //2.透過屬性存取 (return 私人欄位) {私人欄位 = Value}
    private float _atk;
    public float atk { get { return _atk; } set {_atk = value *lv;}}


    //使用快速字元完成的黏巴達寫法49行與54行一樣
    private float _def;
    public float def { get => _def; set => _def = value * lv; }




}
