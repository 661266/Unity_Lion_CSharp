using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine;未包含UI程式庫
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    bool Controlsound=false;
    [Header("聲音的按鈕")]
    public Image SoundButtonImage;
    [Header("聲音開啟圖")]
    public Sprite SoundOpenSprite;
    [Header("聲音關閉圖")]
    public Sprite SoundCloseSprite;
    [Header("聲音拉霸")]
    public Slider SoundSlider;
    [Header("下拉選單")]
    public Dropdown ScreenSizeDropdown;
    //Playerprefs 儲存/取直資料欄位的名稱
    string SaveAudioSlider = "SaveAudioSlider";
    private void Start()
    {
        Control_sonud();
        //SoundSlider.value =SaveData.SaveAudioSlider;
        SoundSlider.value = PlayerPrefs.GetFloat(SaveAudioSlider);
        AudioListener.volume = SoundSlider.value;
    }


    private void FixedUpdate()
    {
        AudioListener.volume = SoundSlider.value;
        //print("ScreenSizeDropdown:"+ScreenSizeDropdown.value);
        /*if (ScreenSizeDropdown.value == 0)
        {
            //設定遊戲執行黨的解析度Screen.SerResolution(寬度，高度，是否全螢幕);
            Screen.SetResolution(1080, 1920, false);
        }
        if (ScreenSizeDropdown.value == 1)
        {
            Screen.SetResolution(720, 1280, false);
        }
        if (ScreenSizeDropdown.value == 2)
            Screen.SetResolution(480, 800, false);
    }
    */
        switch (ScreenSizeDropdown.value)
        {
            case 0:
                Screen.SetResolution(1080, 1920, false);
                break;
            case 1:
                Screen.SetResolution(720, 1280, false);
                break;
            case 2:
                Screen.SetResolution(480, 800, false);
                break;




        }

    }

    public void Update()
    {
        AudioListener.volume = SoundSlider.value;
    }

    #region 下一關
    public void NextScene ()
    {

        //Application.LoadLevel("場景名稱");
        //Application.LoadLevel(逞景名稱ID);
        //Application.loadedLevel讀取當前關卡名稱
        //Application.LoadLevel(Application.loadedLevel);重新遊戲
        //儲存聲音的Slider的value
        //SaveAudioSlider.LoadLevel = SoundSlider.value;
        //儲存浮點數 PlayerPrefs.SetFloat(儲存欄位名稱,儲存浮點數)
        //儲存字串 PlayerPrefs.SetString(儲存欄位名稱,儲存字串)
        //儲存整數 PlayerPrefs.SetInt(儲存欄位名稱,儲存整數值)
        PlayerPrefs.SetFloat(SaveAudioSlider, SoundSlider.value);
        Application.LoadLevel("Level");
    }
    #endregion
    #region 遊戲關閉
    public void Quit()
    {
        //輸出成遊戲執行才可測試
        Application.Quit();
    }
    #endregion
    #region 音樂控制
    public void Control_sonud()
    {    
        //!相反的意思
        Controlsound = !Controlsound;
        if(Controlsound == true)
        {
            //整體遊戲音樂的開啟
            AudioListener.pause = false;
            //音樂的按鈕換成 開成聲音圖片
            SoundButtonImage.sprite = SoundOpenSprite;
        }
        else
        {
            //整體遊戲聲音的關閉
            AudioListener.pause = true;
            //音樂的按鈕換成 關成聲音圖片
            SoundButtonImage.sprite = SoundCloseSprite;
        }

    }
    #endregion
    public void changeaudioslider() 
    {
    if (SoundSlider.value == 0 )
        {
            Controlsound = true;
            Control_sonud();
        }
        else
        {
            Controlsound = false;
            Control_sonud();
        }



    }



}
