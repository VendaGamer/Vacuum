using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenator : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI levelLabel;
    private int current = 1;

    private void Start()
    {
        levelLabel.text = "Level: "+current;
    }
    public void LoadNext()
    {
        if (current == 5)
        {
            SceneManager.LoadScene(2 + current);
            return;
        }
        if(current ==1) { 
        SceneManager.LoadScene(2);
        }
        current++;
        SceneManager.LoadScene(2+current, LoadSceneMode.Additive);
        levelLabel.text = "Level: " + current;
    }
    public void Restart()
    {
        SceneManager.LoadScene(2);
        SceneManager.LoadScene(3 + current, LoadSceneMode.Additive);
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
