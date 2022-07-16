using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
#pragma warning disable CS0618 // Type or member is obsolete, i dont give a flying fuck


    public string PlayScene;
    public string TestingEnvironment;

    [Space]
    [Header("Monster Death Scene")]
    public int Chance;
    public string MonsterDeathScene;

    public void PlayBtn()
    {
        if (BuildInfo._Developer == true)
        {
            SceneManager.LoadScene(TestingEnvironment);
        }
        else if (BuildInfo._Developer == false)
        {
            SceneManager.LoadScene(PlayScene);
        }
        
    }

    private void Start()
    {
        float randint = Random.RandomRange(Chance, 100);

        if (randint == Chance)
        {
            SceneManager.LoadScene(MonsterDeathScene);
        }
    }



}
