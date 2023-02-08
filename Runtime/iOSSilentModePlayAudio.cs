// ReSharper disable RedundantUsingDirective

using System.Runtime.InteropServices;
using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// iOS で消音モードでもオーディオを再生できるようにするクラス
    /// https://forum.unity.com/threads/problem-with-mute-button-ios-silent-button.387579/#post-4727657
    /// </summary>
    public static class iOSSilentModePlayAudio
    {
        //================================================================================
        // 関数(static)
        //================================================================================
#if UNITY_IOS
        [DllImport( "__Internal" )]
        private static extern void _SetAudioSession();

        public static void SetAudioSession()
        {
            _SetAudioSession();
        }
#else
        public static void SetAudioSession()
        {
        }
#endif
    }
}