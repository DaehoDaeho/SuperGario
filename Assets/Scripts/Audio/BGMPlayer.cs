using UnityEngine;

public class BGMPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip bgmClip;

    private void Start()
    {
        PlayBGM();
    }

    void PlayBGM()
    {
        audioSource.clip = bgmClip;
        audioSource.loop = true;
        audioSource.volume = 0.7f;
        audioSource.Play();
    }

    public void StopBGM()
    {
        audioSource.Stop();
    }
}
