using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance { get; private set; }

    [SerializeField] public AudioSource bgm;
    [SerializeField] private GameObject Audio;

    [SerializeField] private AudioClip MenuBgm;
    [SerializeField] private AudioClip IngameBgm;

    private void Awake()
    {
        DontDestroyOnLoad(Audio);
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(Instance);
        }
    }

    void OnEnable()
    {
        // �� �Ŵ����� sceneLoaded�� ü���� �Ǵ�.
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // ü���� �ɾ �� �Լ��� �� ������ ȣ��ȴ�.
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case "Menu": bgm.clip = MenuBgm; break;
            case "LoadingScene": bgm.clip = null; break;
            case "StageSelect": bgm.clip = MenuBgm; break;
            case "Ingame 0": bgm.clip = IngameBgm; break;
            case "Ingame 1": bgm.clip = IngameBgm; break;
            case "Ingame 2": bgm.clip = IngameBgm; break;
            case "Ingame 3": bgm.clip = IngameBgm; break;
            case "Ingame 4": bgm.clip = IngameBgm; break;
            case "Ingame 5": bgm.clip = IngameBgm; break;
            case "Ingame 6": bgm.clip = IngameBgm; break;
        }

        bgm.Play();
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void SetMusicVolume(float volume)
    {
        bgm.volume = volume;
    }
}
