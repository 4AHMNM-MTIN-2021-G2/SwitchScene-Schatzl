using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
	
	public void funcScene1() {
        SceneManager.LoadScene("Scene1");
    }
	
	public void funcScene2() {
        SceneManager.LoadScene("Scene2");
    }
}
