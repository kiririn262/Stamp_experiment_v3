using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Const;

public class StampAction_Mogura : MonoBehaviour
{
    public GameObject EventMaster;
    void OnTriggerEnter(Collider other){
        if(other.tag == "first"){
            EventMaster.GetComponent<Timer>().a = true;
            code.delete_obj(other.gameObject);
        }
        else if(other.tag == "target"){
            EventMaster.GetComponent<Event_master>().Instant_target();
            EventMaster.GetComponent<Event_master>().CountUp();
            code.delete_obj(other.gameObject);
        }
        else{}
    }
}
