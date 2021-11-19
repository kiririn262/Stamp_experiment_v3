using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Const;

//namespace Stamp{
    [RequireComponent(typeof(Rigidbody))]
    public class Stamp : MonoBehaviour
    {
        public enum Type{
            Mogura,
            Stamp
        };
        public Type _type;
        public GameObject EventMaster;
        void OnTriggerEnter(Collider other){
            switch(_type)
            {
                case Type.Mogura:
                    if(other.tag == "first"){
                        #if UNITY_EDITOR
                            Debug.Log("firstにあたった");
                        #endif
                        EventMaster.GetComponent<Timer>().a = true;
                        code.delete_obj(other.gameObject);
                    }
                    else if(other.tag == "target"){
                        #if UNITY_EDITOR
                            Debug.Log("targetにあたった");
                        #endif
                        EventMaster.GetComponent<Event_master>().Instant_target();
                        EventMaster.GetComponent<Event_master>().CountUp();
                        code.delete_obj(other.gameObject);
                    }
                break;

                case Type.Stamp:
                    if(other.tag == "board"){
                        #if UNITY_EDITOR
                            Debug.Log("boardにあたった");
                        #endif
                        EventMaster.GetComponent<Event_master>().Instant_stamp(0);
                    }
                break;

                default:
                break;
             }
        }
        // void OnCollisionEnter(Collision other)
        // {
            // switch(_type)
            // {
                // case Type.Stamp:
                    // if(other.gameObject.tag == "board"){
                    //     #if UNITY_EDITOR
                    //         Debug.Log("boardにあたった");
                    //     #endif
                    //     EventMaster.GetComponent<Event_master>().Instant_stamp(0);
                    // }
                    // else{}
                // break;

                // default:
                // break;
            // }
        // }
    }
//}