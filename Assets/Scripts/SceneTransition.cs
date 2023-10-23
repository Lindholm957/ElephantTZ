using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] private int _newBuildSceneIndex;
    
    public void Transition()
    {
        SceneManager.LoadScene(_newBuildSceneIndex);
    }
}
