#import "AVFoundation/AVFoundation.h"

extern "C" {
   void _SetAudioSession()
   {
       [[AVAudioSession sharedInstance] setCategory:AVAudioSessionCategoryPlayback error:nil];
       [[AVAudioSession sharedInstance] setActive:YES error:nil];
   }
}