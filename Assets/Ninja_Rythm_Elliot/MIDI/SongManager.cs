using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.Interaction;
using System.IO;
using System;

public class SongManager : MonoBehaviour
{
    public static SongManager Instance;
    public AudioSource audioSource;
    public Lane[] lanes;
    public float songDelayInSeconds;
    public double marginOfError; // in seconds

    public int inputDelayInMilliseconds;

    public float noteTime;
    public float noteSpawnY;
    public float noteTapY;
    public float noteDespawnY
    {
        get
        {
            return noteTapY - (noteSpawnY - noteTapY);
        }
    }

    public static MidiFile midiFile;
    public string midiFileName;

    // Start is called before the first frame update



    void Start()
    {
        Instance = this;

        string filePath = Application.streamingAssetsPath + "/" + midiFileName + ".mid";
        StartCoroutine(LoadMidiFile(filePath));

        string path = "";

        #if UNITY_ANDROID && !UNITY_EDITOR
        AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject currentActivity = jc.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaObject assetManager = currentActivity.Call<AndroidJavaObject>("getAssets");
        path = Application.streamingAssetsPath.Replace(Application.dataPath, "") + "file:///android_asset/";
        #else
        path = Application.streamingAssetsPath + "/";
        #endif


    }

    private IEnumerator LoadMidiFile(string filePath)
    {
        WWW www = new WWW(filePath);
        yield return www;

        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.LogError("Error loading MIDI file: " + www.error);
            yield break;
        }

        byte[] results = www.bytes;
        using (var stream = new MemoryStream(results))
        {
            midiFile = MidiFile.Read(stream);
            GetDataFromMidi();
        }
    }

    public void GetDataFromMidi()
    {
        var notes = midiFile.GetNotes();
        var array = new Melanchall.DryWetMidi.Interaction.Note[notes.Count];
        notes.CopyTo(array, 0);

        foreach (var lane in lanes) lane.SetTimeStamps(array);

        Invoke(nameof(StartSong), songDelayInSeconds);
    }

    public void StartSong()
    {
        audioSource.Play();
    }

    public static double GetAudioSourceTime()
    {
        return (double)Instance.audioSource.timeSamples / Instance.audioSource.clip.frequency;
    }



    void Update()
    {

    }
}