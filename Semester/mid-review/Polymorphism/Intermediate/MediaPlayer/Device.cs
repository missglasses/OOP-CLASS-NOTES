using System;

public class Device {
    private MediaPlayer mediaPlayer;

    //constructor
    public Device(MediaPlayer mediaPlayer){
        this.mediaPlayer=mediaPlayer;
    }

    //methods
    public void PlayAudio(){
        mediaPlayer.PlayAudio();
    }

    public void PlayVideo(){
        mediaPlayer.PlayVideo();
    }
}