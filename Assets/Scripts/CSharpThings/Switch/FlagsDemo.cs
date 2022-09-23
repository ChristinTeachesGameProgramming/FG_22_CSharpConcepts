using System;

public class FlagsDemo
{
    [Flags]
    public enum Settings
    {
        Mute = 0,
        LowGraphicMode = 1,
        InvertYAxis = 2,
        BigText = 4,
        HighContrast = 8
    }

    public void Init()
    {
        //bitwise operations
        var preset1 = Settings.Mute; //00001
        var preset2 = Settings.LowGraphicMode | Settings.InvertYAxis; //00110

        var userSetting = preset1 | Settings.InvertYAxis; //00101
        
        var userSetting2 = preset2 & ~Settings.InvertYAxis;


        if ((userSetting & Settings.Mute) == Settings.Mute)
        {
            //Tell AudioPlayer to mute sound
        }

        if(userSetting.HasFlag(Settings.Mute))
        {
            //Tell AudioPlayer to mute sound
        }
    }
}

