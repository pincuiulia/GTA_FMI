using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenu : MonoBehaviour
{
    // incarca scena jocului si incepe jocul
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // !!!VERIFICA sa fie scena jocului adaugata in Build Settings si schimba numele!!!
    }

    // deschide meniul de optiuni
    public void OpenOptions()
    {
        // ori incarcam o scena separata ori activam direct obiectul UI (probabil a doua optiune)
        // SceneManager.LoadScene("OptionPanel");
        // SAU
        // optionPanel.SetActive(true);
    }

    // inchide jocul
    public void ExitGame()
    {
        // verifica daca aplicatia ruleaza in Editor
#if UNITY_EDITOR
        // opreste modeul Play
        EditorApplication.isPlaying = false;
#else
        // inchide aplicatia
        Application.Quit();
#endif
    }
}
