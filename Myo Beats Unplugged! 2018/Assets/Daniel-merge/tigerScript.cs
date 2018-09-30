using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using System.Diagnostics;
using System;



public class tigerScript : MonoBehaviour
{
    
    

    




    // for note spawner
    public GameObject orangePrefab;
    public Transform spawn;
    private bool spawnNow = false;
    bool disabled = false;



    public AudioClip musicClip;
    public AudioSource musicSource;

   
    //Stopwatch playTimer = new Stopwatch();

    System.Timers.Timer cTimer = new System.Timers.Timer();
    bool pulseNow = false;

    bool resetNow = false;

    private double bpm = 109;
    private int startDelay = 000;

    System.Timers.Timer startDelayTimer = new System.Timers.Timer();
    System.Timers.Timer bTimer = new System.Timers.Timer();

    // Use this for initialization
    void Start()
    {
       
        disabled = false;
        // for note spawner
        System.Timers.Timer dTimer = new System.Timers.Timer();
        dTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        dTimer.Interval = 550.45;
        dTimer.Enabled = true;
        spawn = gameObject.transform;




        startDelayTimer.Elapsed += new ElapsedEventHandler(lockBpm);
        startDelayTimer.Interval = startDelay;
        startDelayTimer.Enabled = true;

        bTimer.Elapsed += new ElapsedEventHandler(pulse);
        bTimer.Interval = (1 / (bpm / 60)) * 1000;
        bTimer.Enabled = true;

        musicSource.clip = musicClip;
        musicSource.Play();

        
    }

    // Update is called once per frame
    void Update()
    {
       // int i = 0;
       
        //TimeSpan ts = playTimer.Elapsed;
        // i = ts.Milliseconds;
        
            // }

            // }
            // for note spawner
            if (spawnNow == true && disabled == false)
            {
                spawnNow = false;
                Instantiate(orangePrefab, spawn);
            }

        

            SpriteRenderer myRenderer = GetComponent<SpriteRenderer>();
            if (pulseNow == true)
            {

                pulseNow = false;
                myRenderer.color = Color.red;
                cTimer.Enabled = true;
            }

            if (resetNow == true)
            {
                resetNow = false;
                myRenderer.color = Color.white;
                cTimer.Enabled = false;
            }
        }

        // when start delay is over
        void lockBpm(object source, ElapsedEventArgs e)
        {
            startDelayTimer.Enabled = false;
            disabled = false;
        }

        void pulse(object source, ElapsedEventArgs e)
        {

            pulseNow = true;
            cTimer.Elapsed += new ElapsedEventHandler(reset);
            cTimer.Interval = 200;
            cTimer.Enabled = true;
        }

        void reset(object source, ElapsedEventArgs e)
        {

            resetNow = true;
        }

        // for note spawner
        void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            spawnNow = true;


        }

        void disable()
        {
            disabled = true;
        }

    


}
