using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

[AddComponentMenu("Scripts/Create_Data/Event/Timer2")]
public class Timer2: MonoBehaviour
{
    //変数
    public float GameTime = 30.0f;
    public float countdown = 3.0f;
    private int timer = 0;
    public TextMeshPro TMP;
    private int result = 0;
    private bool flag, b = false;
    [System.NonSerialized] public bool a = false;

    //Updata
    private void Update()
    {
        if(a == true){
            if(countdown > 0)
            {
                // Console.Clear_Error();
                TMP.gameObject.SetActive(true);
                //時間をカウントダウンする
                countdown -= Time.deltaTime;
                //時間を表示する
                timer = (int)countdown;
                TMP.text = timer.ToString();
            }
            //countdownが0以下になったとき
            else if (countdown <= 0)
            {
                if(flag == false)
                {
                    flag = true;
                    def_Start();
                }
                else{
                    if(GameTime > 0f)
                    {
                        GameTime -= Time.deltaTime;
                    }
                    else if(GameTime <= 0)
                    {
                        def_Fin();
                    }
                }
            }
        }
    }
    //関数
    public void def_Start()
    {
        TMP.text = "Start!!";
        GetComponent<Event_master>().Instant_target();
        TMP.gameObject.SetActive(false);
        // TMP.gameObject.meshRender.enable = false;
        // TMP.GetComponent<TextMeshPro>().enable = false;
        // Destroy(TMP.gameObject, 1);
    }
    public void def_Fin(){
        if(b == false){
            this.result = GetComponent<Event_master>().num;
            //Console.Console_Activate(true);
            //UnityEngine.Debug.LogError("結果："+ result + "個");
            // Microsoft.MixedReality.Toolkit.Examples.Demos.Input.Set_HandRayPointer(true);
            b = true;
        }
        TMP.text = "Fin!!\nresult:"+ this.result;
        // TMP.gameObject.meshRender.enable = true;
        // TMP.GetComponent<TextMeshPro>().enable = true;
        TMP.gameObject.SetActive(true);
    }
}