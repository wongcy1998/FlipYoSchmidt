﻿/*

using System.Collections;

    private void Update()
    {
        if (!GetComponent<AudioSource>().isPlaying && destroy)
        {
            gameEnding.BallDestroyed();
            Destroy(this.gameObject);
        }
    }
    {
        if (collision.gameObject.tag == "Lava")
        {
            GetComponent<AudioSource>().Play();
            destroy = true;
        }
    }