using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    public void Awake()
    {
        //DontDestroyOnLoad切換場景時不要把括弧內的物件刪除
        //gameObject帶表物件自己
        DontDestroyOnLoad(gameObject);
    }




}
