using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreen_script : MonoBehaviour
{
    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
