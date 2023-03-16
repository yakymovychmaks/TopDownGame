using UnityEngine.SceneManagement;
using UnityEngine;

namespace Scenes.Scripts.Menu
{
    public class MeinMeny : MonoBehaviour
    {
        public void PlayGame() => SceneManager.LoadScene("Store");
        public void ExitGame() => Application.Quit();
    }
}
