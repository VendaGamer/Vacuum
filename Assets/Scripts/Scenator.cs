using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenator : MonoBehaviour
{
    private int current = 0;
    public void Reset()
    {
        SceneManager.LoadScene(current);
    }
    public void LoadNext()
    {
        SceneManager.LoadScene(2);
        current++;
        SceneManager.LoadScene(2+current, LoadSceneMode.Additive);
    }
    public void Death()
    {
        SceneManager.LoadScene(2);
        SceneManager.LoadScene(2 + current, LoadSceneMode.Additive);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

}