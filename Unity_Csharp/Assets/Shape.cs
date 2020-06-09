using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 形狀:基底類別
/// </summary>
public class Shape : MonoBehaviour
{
    [Header("長寬高")]
    public float length;
    public float width;
    public float heigth;
    /// <summary>
    /// 體積
    /// </summary>
    public float Volume;

    /// <summary>
    /// 取得體積
    /// virtual虛擬:允許子類別覆寫
    /// </summary>
    /// <returns></returns>
    public virtual float GetVolume()
    {
        Volume = length * width * heigth;
        return Volume;

    }




}
