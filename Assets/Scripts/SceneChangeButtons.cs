using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeButtons : MonoBehaviour
{
    public void LoadCarScene()
    {
        SceneManager.LoadScene(1,LoadSceneMode.Single);
    }
        
    public void LoadRotateObjScene()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}