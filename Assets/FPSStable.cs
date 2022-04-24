using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSStable : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 240;
        QualitySettings.vSyncCount = 0;
    }
}
