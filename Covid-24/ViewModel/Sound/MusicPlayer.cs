using System.IO;
using System.Media;

namespace Covid_24.ViewModel.Sound
{
    internal class MusicPlayer : APlayer
    {
        public MusicPlayer()
        {
            _player = GetPlayer();
            _manager = new SoundManager();
        }

        public override void Play()
        {
            bool _soundFinished = true;

            _player.Load();
            _player.Play();
            VolumeBlocker();

            if (_soundFinished)
            {
                _soundFinished = false;
                Task.Factory.StartNew(() => { _player.PlaySync(); _soundFinished = true; });
            }
        }

        protected override void VolumeBlocker()
        {
            _manager.VolMax();
        }

        protected override SoundPlayer GetPlayer()
        {
            string _WaweFile = "\\View\\ressources\\Baguette_Anthem.wave";
            string _rootLocation = typeof(MainWindow).Assembly.Location;
            string _parentDirectory = Path.Combine(Path.GetDirectoryName(_rootLocation), "..\\..\\..");
            string _fullPath = Path.GetFullPath(_parentDirectory);
            string _WavePath = _fullPath + _WaweFile;

            return new SoundPlayer(_WavePath);
        }
    }
}
