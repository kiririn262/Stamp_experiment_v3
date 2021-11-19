using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    [AddComponentMenu("Scripts/Create_Data/Event/NoneBoundaryWalls")]
    public class NoneBoundaryWalls : MonoBehaviour
    {
        [SerializeField] private bool ON = true;
        private void Start()
        {
            #if UNITY_EDITOR
                ON = false;
            #else
                ON = true;
            #endif

            if(ON == true) CoreServices.BoundarySystem.ShowBoundaryWalls = false;
        }
    }
}