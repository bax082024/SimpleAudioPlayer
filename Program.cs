﻿using System;
using System.IO;
using System.Runtime.CompilerServices;
using NAudio.Wave;

class AudioPlayer
{
  private WaveOutEvent outputDevice;
  private AudioFileReader audioFile;
  private string[] playlist;
  private int currentTrackIndex;

  public AudioPlayer(string folderPath) 
  {
    playlist = Directory.GetFiles(folderPath, "*.mp3");
  }

  public void Play()
  {
    if (playlist.Length == 0)
    {
      Console.WriteLine("No Mp3 Files Found.");
      return;
    }

    PlayTrack(currentTrackIndex);

    private void PlayTrack(int trackIndex)
    {
      
    }


  }
}