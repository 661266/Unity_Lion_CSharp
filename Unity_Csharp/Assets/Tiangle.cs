using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 三角形 繼承 形狀類別
/// 三角形繼承需要覆寫
/// </summary>
public class Tiangle : Shape
{
    /// <summary>
    /// override 覆寫:覆寫父物件
    /// </summary>
    public override float GetVolume()
    {
        Volume = length * width * heigth / 2;
        return Volume;
    }




    private void Start()
    {
        print(gameObject + "體積" + GetVolume());
    }

}
