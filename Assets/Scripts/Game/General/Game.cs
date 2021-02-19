using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    private const string _sceneGame = "Game";

    [SerializeField] private Ball _ball;

    private void OnEnable()
    {
        _ball.Crashed += OnCrashed;
    }

    private void OnDisable()
    {
        _ball.Crashed -= OnCrashed;
    }

    public void OnCrashed()
    {
        SceneManager.LoadScene(_sceneGame);
    }
}
