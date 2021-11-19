using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Const{
    public static class code
    {
        // public static string name = null;
        // public static void loadScene(){
        //     SceneManager.LoadScene(name);
        // }
        public static void loadScene(int num){
            SceneManager.LoadScene(num);
        }
        public static void loadScene(string name){
            SceneManager.LoadScene(name);
        }

        public static void delete_obj(GameObject a){
            GameObject.Destroy(a);
        }
        public static void delete_obj(GameObject a, float delay){
            GameObject.Destroy(a, delay);
        }
        public static void Instant(GameObject obj, GameObject marker, float Range, float height){
            if (obj != null){
                Vector3 v = new Vector3(Random.Range(-1 * Range, Range), height, Random.Range(-1 * Range, Range));
                GameObject box = Object.Instantiate<GameObject>(obj, marker.transform.position + v, Quaternion.identity) as GameObject;
            }
        }
        public static void Instant(GameObject obj, GameObject stamp, float height){
            if (obj != null){
                Vector3 vec = new Vector3(stamp.transform.position.x, height, stamp.transform.position.z);
                GameObject mark = Object.Instantiate<GameObject>(obj, vec, Quaternion.identity) as GameObject;
            }
        }
    }
}