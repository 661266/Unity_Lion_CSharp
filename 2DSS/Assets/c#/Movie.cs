using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class Movie : MonoBehaviour
{

    public VideoPlayer Movie_;
    float Timer;

    private void Start()
    {
        //依照時間持續呼叫function
        //InvokeRepeating(function名稱,遊戲一開始要等待幾秒
        //才進行第一次呼叫，第二次呼叫...需等待幾秒)

        InvokeRepeating("CheckMovie", 3f, 0.1f);
    }
    //Update is called once per frame
    private void Update()
    {
        //Timer = Timer + 0.1f;
        //Timer += 0.1f;
        Timer += Time.deltaTime;
        if (Timer > 3f)
        {
            //Movie_.isPlaying=true 影片還沒撥放結束
            //Movie_.isPlaying=false 影片撥放結束
            if (Movie_.isPlaying == false)
                Application.LoadLevel("Game");

        }
    }
       
    public void NextScene()
        {
            Application.LoadLevel("Game");
        }
}


