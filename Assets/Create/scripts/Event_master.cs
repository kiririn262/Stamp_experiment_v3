using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using Microsoft.MixedReality.Toolkit.Input;
//using Microsoft.MixedReality.Toolkit.Utilities;
using Const;


[AddComponentMenu("Scripts/Create_Data/Event/Event_master")]
public class Event_master : MonoBehaviour
{
    //[SerializeField] public bool VuforiaMode = true;
    //public GameObject ImageTarget;
    //private GameObject parent;
    //public GameObject[] objs = new GameObject[2];
    public GameObject tracker_board;
    [System.NonSerialized]
    public int num = 0;
    public float height = 0.08f;
    public float Random_Range = 0.25f;
    public GameObject First;
    public GameObject Instant;
    public GameObject _stamp;
    public GameObject[] _mark;

    // private void Awake() {
    //     //Console.Console_Activete(false);
    //     Console.Clear_Error();
    //     #if UNITY_EDITOR
    //         Debugger.VuforiaMode = this.VuforiaMode;
    //     #else
    //         //this.VuforiaMode = Debugger.VuforiaMode;
    //     #endif
    // }
    // private void Start() {
    //     /*if(SceneManager.GetActiveScene().name != "Home") {
    //     if(this.VuforiaMode == true) Debugger.VuforiaMode = true;
    //     else Debugger.VuforiaMode = false;*/
    //     if(Debugger.VuforiaMode == true) Set_Vuforia();
    //     //}
    // }
    // private void Set_Vuforia(){
    // /*DebugMode,Vuforiaなし⇒Vuforiaを無効化*/ //無効化しようとするとOFFにされる
    // // if(VuforiaMode == false && Debugger.DebugMode == true){
    // //     /*SceneContentへ移動*/
    // //     Obj.Parent(parent, ImageTarget);
    // //     Obj.Hierarchy_Move(objs, parent);
    // //     /*image_targetを非表示*/
    // //     ImageTarget.SetActive(false);
    // // }
    // /*有効*/
    // //else {
    //     //image_targetへ移動
    //     Obj.Hierarchy_Move(objs, ImageTarget);
    //     //image_targetを表示
    //     //ImageTarget.SetActive(true);
    // //}
    // }

    public void CountUp(){
        num++;
    }

    public void Instant_first(){
        code.Instant(First, tracker_board, 0, height);
    }
    public void Instant_target(){
        code.Instant(Instant, tracker_board, Random_Range, height);
        // if (Instant != null)
        // {
        //     /*GameObject box = Instantiate(Instant, tracker_board.transform.position, Quaternion.identity) as GameObject;
        //     Vector3 v = new Vector3(Random.Range(-1 * Random_Range, Random_Range), height, Random.Range(-1 * Random_Range, Random_Range));
        //     box.gameObject.transform.position += v;*/
        //     Vector3 v = new Vector3(Random.Range(-1 * Random_Range, Random_Range), height, Random.Range(-1 * Random_Range, Random_Range));
        //     GameObject box = Instantiate(Instant, tracker_board.transform.position + v, Quaternion.identity) as GameObject;
        // }
    }
    public void Instant_stamp(int num){
        code.Instant(_mark[num], _stamp, height);
    }
}