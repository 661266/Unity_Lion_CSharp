using UnityEngine;

public class Person : MonoBehaviour
{
    [Header("身高")]
    public float height;
    [Header("體重")]
    public float weight;

    // 定義方法語言:
    //修飾詞 傳回類型 方法名稱(參數) {陳述式}
    //Void 無回傳:當使用此方法時不會得到任何回傳資料
    public void Talk()
    {
        //gameObject 套用此腳本的物件
        //gameObject.name 套用此腳本的物件的名稱
        print("嗨~~~~~" + gameObject.name);
    }
    //傳回類型不是Void
    //使用此方法會得到回傳資料，必須使用關鍵字 return 
    ///<summary>
    ///計算入的BMI
    ///</summary>
    ///<returns>計算完的BMI</returns>>



    public float BMI()
    {
        //MBI公式
        float result = weight / ((height / 100) * (height / 100));
        //傳回 result
        return result;
    }

    //參數的語法:類型 名稱
    ///<summary>
    ///走路方法
    ///</summary>
    ///<param name="speed">需要以多少速度走路</param>
    public void Walk(int speed, string direction = "前方", string sound = "嘎")
    {
        print("用時速" + speed + "公里走路");
        print("走路音效" + sound);
        print("走路音效" + direction);
    }
    //攻擊方法:徒手
    public void AttackWithHand()
    {
    }
    //攻擊方法:拿武器攻擊:音效
    public void AttackWithWeapon()
    { 
        /// <summary>
    /// 徒手攻擊
    /// </summary>
    ///<param name="weapon">想要使用的武器</param>
    }
    public void Attack()
    {
        print(gameObject.name + "徒手攻擊");


    }
    //多載 Overload
    //1.相同名稱的方法
    //2.參數數量不同 或者 參數類型不同
    /// <summary>
    /// 使用武器攻擊
    /// </summary>
    ///<param name="weapon">想要使用的武器</param>

    public void Attack(string weapon)
    {
        print(gameObject.name + "用武器" + weapon + "攻擊111");
        print("攻擊音效");
    }

    //讓 Unity 按鈕 Button 使用方法條件:
    //1.修飾詞為公開 public
    //2.參數數量小魚等於1
    ///<summary>
    ///技能
    /// </summary>
    public void skill()
    {
        print(gameObject.name + "施放技能");
    }

}









