using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMonobehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject optionsMenu;
    [SerializeField]
    private GameObject storeMenu;

    public void StartGame()
    {
        SceneManager.LoadScene("Breakout", LoadSceneMode.Single);
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void GoToOptions()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void GoToStore()
    {
        mainMenu.SetActive(false);
        storeMenu.SetActive(true);
    }
    public void ReturnToMainMenu()
    {
        optionsMenu.SetActive(false);
        storeMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
