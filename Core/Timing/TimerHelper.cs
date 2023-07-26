using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public delegate void TimerAction(float current);

public class TimerHelper
{
    /// <summary>
    /// Timing in seconds
    /// </summary>
    public static void CreateTimer(float targetTime, bool isRepeate, TimerAction callback,
        bool isDown = false, bool ignoreTimeScale = true, float timeOffset = 0f)
    {
        var timer = new GameObject("timer_instance");
        var instance = timer.AddComponent<TimerInstance>();
        
        instance.StartTiming(targetTime, isRepeate, callback, isDown, ignoreTimeScale, timeOffset); ;
        instance.IsStarted = true;
    }
}