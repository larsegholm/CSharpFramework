namespace Lab2.Interfaces {
    public abstract class Mobile {

        public IPlayback PlaybackComponent { get; set; }
        public IDisplay DisplayComponent {get; set; }

        public void Play(object data) {
            PlaybackComponent.Play(data);
        }

        public void Display(object data) {
            DisplayComponent.Display(data);
        }
    }
}
