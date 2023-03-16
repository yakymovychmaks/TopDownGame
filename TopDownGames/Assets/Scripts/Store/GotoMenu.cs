using UnityEngine.SceneManagement;
using UnityEngine;

public class GotoMenu : MonoBehaviour
{
    public void GoToMainMenu() => SceneManager.LoadScene("MainMenu");
}
