using UnityEngine;

/// <summary>
/// AudioSource를 이용해서 효과음을 한 번 재생하는 기능을 제공
/// </summary>
public class EffectSoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void PlayEffectSound(AudioClip effectClip)
    {
        audioSource.PlayOneShot(effectClip);
    }
}
