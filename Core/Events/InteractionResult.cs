using System;
using System.Collections.Generic;

public enum InteractionResult
{
    Success,
    Failure,
    Pass
}

public static class InteractionDebugger
{
    public static void Debug(InteractionResult result)
    {
        switch (result)
        {
            case InteractionResult.Success:
                break;
            case InteractionResult.Failure:
                UnityEngine.Debug.LogError("Interaction had failed!");
                break;
            case InteractionResult.Pass:
                UnityEngine.Debug.LogWarning("Interaction had been passed!");
                break;
        }
    }
}