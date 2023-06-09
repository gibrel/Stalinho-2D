using UnityEngine;

namespace Stalinho2D.Audio
{
    public class ButtonSounds : MonoBehaviour
    {
        public void ButtonClick()
        {
            SoundManager.PlaySound(SoundManager.Sound.ButtonClick);
        }

        public void ButtonHover()
        {
            SoundManager.PlaySound(SoundManager.Sound.ButtonClick);
        }

        public void ButtonSwitch()
        {
            SoundManager.PlaySound(SoundManager.Sound.ButtonClick);
        }
    }
}