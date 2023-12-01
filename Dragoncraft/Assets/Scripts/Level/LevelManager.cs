using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _miniMapCameraPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_miniMapCameraPrefab);
        SceneManager.LoadScene("GameUI", LoadSceneMode.Additive);
    }
}
