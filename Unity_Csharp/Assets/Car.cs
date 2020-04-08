
using UnityEngine;

// 註解:用來記錄只會在此腳本內出現
// 3個/:是摘要 用來描述此內容，會在其他腳本出現-以便維護與擴充性
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
    //資料類型 欄位名稱(指定值);
    //預設值 int float 為0
    //string 為 ""
    //bool   為 false

    int cc = 2000;
    float weight = 100.9f;
    string brand = "BMW";
    bool brake = false;
}
