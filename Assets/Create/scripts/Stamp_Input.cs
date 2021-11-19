using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Const;

public class Stamp_Input : MonoBehaviour
{
    [SerializeField]
    private GameObject obj = null;
    private float colliderTimer = 0;
    public float Timer = 0;
    void Update()
    {
        colliderTimer -= Time.deltaTime;
        if(Input.GetKey(KeyCode.Tab)) code.loadScene("menu");

        if(Input.GetKeyDown(KeyCode.LeftControl)){
        //if(Input.GetKey(KeyCode.LeftControl)){
            #if UNITY_EDITOR
                Debug.Log("LCtrl");
            #else
            #endif
            obj.gameObject.GetComponent<Collider>().enabled = true;
            colliderTimer = Timer;
            // obj.SetActive(true);
            //指定された「コルーチン」を呼び出す
            // StartCoroutine("sleep");
        }
        else{
            if(colliderTimer <= 0)
            obj.gameObject.GetComponent<Collider>().enabled = false;
            // obj.SetActive(false);
        }
    }

    // //「コルーチン」で呼び出すメソッド
    // IEnumerator sleep(){

    //     // Debug.Log("開始");
    //     yield return new WaitForSeconds(1);  //1秒待つ
    //     // Debug.Log("1秒経ちました");
    // }
}