using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GivePriority : MonoBehaviour
{
    public CinemachineVirtualCamera actualCam;
    public CinemachineVirtualCamera nextCam;


    void GivePrio()
    {
        actualCam.m_Priority -= 1;
        nextCam.m_Priority += 1;
    }
}
