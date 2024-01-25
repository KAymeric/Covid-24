using Covid_24.Sound;
using System.Windows;

namespace Covid_24
{
    public partial class MainWindow : Window
    {
        MusicPlayer _player;
        public MainWindow()
        {
            _player = new MusicPlayer();
            _player.Play();

            InitializeComponent();
        }
    }
}