using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenator : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI levelLabel=null;

    private void Start()
    {
        if (levelLabel == null)
        {
            return;
        }
        levelLabel.text = "Level: "+Levels.Instance.Current;
    }
    public void LoadNext()
    {
        if (Levels.Instance.Current == 5)
        {
            SceneManager.LoadScene(2 + Levels.Instance.Current);
            return;
        }
        SceneManager.LoadScene(2);
        Levels.Instance.Add();
        SceneManager.LoadScene(2+ Levels.Instance.Current, LoadSceneMode.Additive);
    }
    public void LoadFirst()
    {
        SceneManager.LoadScene(2);
        SceneManager.LoadScene(2 + Levels.Instance.Current, LoadSceneMode.Additive);
    }
    public void Restart()
    {
        SceneManager.LoadScene(2);
        SceneManager.LoadScene(3 + Levels.Instance.Current, LoadSceneMode.Additive);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void StartGame()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }

}
