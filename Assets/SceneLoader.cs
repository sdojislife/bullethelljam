using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int _index;
    public void LoadScene()
    {
        SceneManager.LoadSceneAsync(_index);
    }
}
