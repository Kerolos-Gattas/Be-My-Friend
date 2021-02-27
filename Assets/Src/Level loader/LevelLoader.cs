using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelLoader : MonoBehaviour
{
    public Animator animator;
    public float transitionTime = 1;
    public EnemyManager enemyManager;
    private McControls controls;

    private void Awake()
    {
        controls = new McControls();
    }

    // Update is called once per frame
    void Update()
    {
        // Add retry level input
        // Add win animation
        if (enemyManager.AreAllEnemiesDead())
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene + 1 < SceneManager.sceneCountInBuildSettings)
        {
            StartCoroutine(LoadLevel(currentScene + 1));
        }
    }

    IEnumerator LoadLevel(int lvlIndex)
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(lvlIndex);
    }

    private void HandleRetryLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        StartCoroutine(LoadLevel(currentScene));
    }

    private void OnEnable()
    {
        controls.Menu.RetryLevel.performed += context => HandleRetryLevel();
        controls.Menu.Enable();
    }

    private void OnDisable()
    {
        controls.Menu.Disable();
    }
}
