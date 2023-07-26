using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

// Orginal by https://blog.csdn.net/q764424567/article/details/124827131
public class TimerInstance : MonoBehaviour
{
    public float TargetTime;               // 计时时间
    public float StartTime;                // 开始计时时间
    public float TimeOffset;               // 计时偏差
    public bool IsStarted;                   // 是否开始计时
    public bool IgnoreTimeScale = true;  // 是否忽略时间速率
    public bool IsRepeate;                 //是否重复
    public float CurrentTime;                      //当前时间 正计时

    public float DownCurrentTime;                  //倒计时
    public bool IsDown = false;     //是否是倒计时

    public TimerAction UpdateCallback;

    public float TimeNow
    {
        get => IgnoreTimeScale ? Time.realtimeSinceStartup : Time.time;
    }

    public float SurplusTime
    {
        get => Mathf.Clamp(TargetTime - CurrentTime, 0, TargetTime);
    }

    public void StartTiming(float targetTime, bool isRepeate, TimerAction callback, 
        bool isDown = false, bool ignoreTimeScale = true, float timeOffset= 0f)
    {
        this.TargetTime = targetTime;
        this.IsDown = isDown;
        this.IsRepeate = isRepeate;
        this.TimeOffset = timeOffset;
        this.IgnoreTimeScale = ignoreTimeScale;

        this.UpdateCallback = callback;
    }

    private void Update()
    {
        if (IsStarted)
        {
            CurrentTime = TimeNow - TimeOffset - StartTime;
            DownCurrentTime = TargetTime - CurrentTime;

            if (UpdateCallback != null)
            {
                if (IsDown)
                {
                    UpdateCallback(DownCurrentTime);
                }
                else
                {
                    UpdateCallback(CurrentTime);
                }
            }
            if (CurrentTime > TargetTime)
            {
                if (!IsRepeate)
                    Destroy(gameObject);
                else
                    Retiming();
            }
        }
    }

    /// <summary>
    /// 重新计时
    /// </summary>
    public void Retiming()
    {
        StartTime = TimeNow;
        TimeOffset = 0f;
    }
}