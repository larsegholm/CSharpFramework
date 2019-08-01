﻿namespace Lab2.Interfaces.ConsoleApp {
    public abstract class Mobile {

        public IPlayback PlaybackComponent { get; set; }
        public IDisplay DisplayComponent {get; set; }

        public void Play(object data) {
            PlaybackComponent.Play(data);
        }

    }
}