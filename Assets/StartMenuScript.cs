using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    
    public void OnStartClick()
    {
        SceneManager.LoadScene("LevelOne");
        // could add cutscene here
    }

    public void OnQuitClick()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
