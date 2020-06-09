using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 立方體 繼承 形狀類別
/// 繼承可擁有父類別的成員
/// </summary>
public class Cube : Shape
{

    private void Start()
    {
        print(gameObject + "體積:" + GetVolume());


    }
}
