namespace Lab2.Interfaces {
    public abstract class Mobile {

        public IPlayback PlaybackComponent { private get; set; }
        public IDisplay DisplayComponent { private get; set; }

        public void Play(object data) {
            PlaybackComponent.Play(data);
        }

        public void Display(object data) {
            DisplayComponent.Display(data);
        }
    }
}
