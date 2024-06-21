using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene : MonoBehaviour
{
    public void GameScene()
    {
        Application.LoadLevel(1);
    }

    public void CreditScene()
    {
        Application.LoadLevel(2);
    }
}
