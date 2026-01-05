using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip backgroundSound;
    [SerializeField] AudioClip OnPointerEnterSound;

    AudioSource audioSource;
    float sfx_volume = 0.35f;
    private void Start()
    {
        BackgroundManager.OnBackgroundChanged += BackgroundManager_OnBackgroundChanged;
        ButtonSingleUI.OnPointerEntry += ButtonSingleUI_OnPointerEntry;
        audioSource = GetComponent<AudioSource>();
    }

    private void ButtonSingleUI_OnPointerEntry(object sender, System.EventArgs e)
    {
        float enterVolume = 0.05f;
        playClip(OnPointerEnterSound, enterVolume);
    }

    private void BackgroundManager_OnBackgroundChanged(object sender, System.EventArgs e)
    {
        playClip(backgroundSound, sfx_volume);
    }

    private void playClip(AudioClip audioClip,float volume)
    {
        audioSource.PlayOneShot(audioClip,volume);
    }
}
