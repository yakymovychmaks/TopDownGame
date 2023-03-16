using UnityEngine.SceneManagement;
using UnityEngine;


public class StartGame : MonoBehaviour
{
    public void StartsGame() => SceneManager.LoadScene("SampleScene");
}
