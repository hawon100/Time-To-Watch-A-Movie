using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance { get; private set; }

    [SerializeField] public AudioSource bgm;
    [SerializeField] private GameObject Audio;
    [SerializeField] private GameObject audioObj;

    [SerializeField] private AudioClip MenuBgm;
    [SerializeField] private AudioClip IngameBgm;

    private void Awake()
    {
        var objs = FindObjectsOfType<MusicManager>();
        if (objs.Length == 1)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

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
