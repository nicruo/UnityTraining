using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static string GameScene = "Balls";
    public static string MenuScene = "Main";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == MenuScene)
            {
                ExitGame();
            }
            else
            {
                SceneManager.LoadScene(MenuScene);
            }
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(GameScene);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}
