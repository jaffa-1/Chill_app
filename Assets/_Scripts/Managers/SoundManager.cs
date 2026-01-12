using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip backgroundSound;
    [SerializeField] AudioClip OnPointerEnterSound;
    [SerializeField] AudioClip OnTaskCompleteAudio;
    [SerializeField] AudioClip OnTaskRemoveAudio;
    [SerializeField] AudioClip OnTaskAddedAudio;

    AudioSource audioSource;
    float sfx_volume = 0.35f;
    private void Start()
    {
        BackgroundManager.OnBackgroundChanged += BackgroundManager_OnBackgroundChanged;
        ButtonSingleUI.OnPointerEntry += ButtonSingleUI_OnPointerEntry;
        Tasks.OntaskAdded += Tasks_OntaskAdded;
        TaskTemplate.OnTaskCompleted += TaskTemplate_OnTaskCompleted;
        TaskTemplate.OnTaskRemoved += TaskTemplate_OnTaskRemoved;
        audioSource = GetComponent<AudioSource>();
    }

    private void TaskTemplate_OnTaskRemoved(object sender, System.EventArgs e)
    {
        //removed sound
        float enterVolume = 1;
        playClip(OnTaskRemoveAudio, enterVolume);
    }

    private void TaskTemplate_OnTaskCompleted(object sender, System.EventArgs e)
    {
        //completed sound
        float enterVolume = 1;
        playClip(OnTaskCompleteAudio, enterVolume);
    }

    private void Tasks_OntaskAdded(object sender, System.EventArgs e)
    {
        //task added sound
        float enterVolume = 1;
        playClip(OnTaskAddedAudio, enterVolume);
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
