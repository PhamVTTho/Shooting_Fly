using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneManager : MonoBehaviour
{
    [SerializeField] private int sceneIndex;
    public void onLoadScene()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
