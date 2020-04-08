using UnityEngine;

// 註解:用來記錄只會在此腳本內出現
// 3個/:是摘要 用來描述此內容，會在其他腳本出現-以便維護與擴充性(可讀性)
//新增的C# 放在專案內為藍圖
//放在場景物件上為實體物件

public class Car : MonoBehaviour
{
    //認識第一個成員:欄位(field)-儲存資料

    //資料類型
    //CC數 - 2000     - 整數 int
    //重量 - 100      - 浮點數 float
    //品牌 - BMW      - 字串 string
    //煞車 - 是否開啟 - 布林值 bool - true、false

    //用到小數點後面一訂要加 f

    //欄位的語法:
    //修飾詞 資料類型 欄位名稱(指定值)
    //公開 public :允許其他類別存取、顯示在屬性面板(Inspector)上
    //私人 private:不允許；不顯示

    //預設值 int float 為0
    //string 為 ""
    //bool   為 false

    //欄位的屬性 Attribute : Unity 提供用於輔助欄位的功能
    //屬性語法:[屬性名稱(值)]
    //標題[Header("字串")]  一個欄位只能用一個標題&提示
    //提示[Tooltip("字串")] 一個欄位只能用一個標題&提示
    //範圍[Range(最小值,最大值)]-僅限於數值類型資料 int,float
    //也可以使用,來省略一個括號 ex: [Header("是否煞車"),Tooltip("用來儲存這台車子是否為煞車")]


    /// <summary>
    /// Car的cc
    /// </summary>
    [Header("CAR的CC數"),Range(500,5000)]
    public int cc = 2000;
    /// <summary>
    /// Car的重量
    /// </summary>
    [Header("CAR重量")]
    [Tooltip("這個車的重量")]
    [Range(50,350)]
    public float weight = 100.9f;
    /// <summary>
    /// Car的牌子
    /// </summary>
    [Header("品牌")]
    [Tooltip("車的牌子")]
    public string brand = "BMW";
    /// <summary>
    /// 是否煞車
    /// </summary>
    [Header("是否煞車"),Tooltip("用來儲存這台車子是否為煞車")]
    public bool brake = false;
}
