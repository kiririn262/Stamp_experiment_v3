using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Const;

public class ButtonAction : MonoBehaviour
{
    public void goScene(string Scenename){
        //code.name = Scenename;
        //code.loadScene();
        code.loadScene(Scenename);
    }
}
