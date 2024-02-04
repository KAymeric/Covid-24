using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Covid_24.ViewModel.Sound
{
    abstract class APlayer
    {
        protected SoundPlayer _player;
        protected SoundManager _manager;

        public abstract void Play();

        protected abstract void VolumeBlocker();

        protected abstract SoundPlayer GetPlayer();
    }
}
