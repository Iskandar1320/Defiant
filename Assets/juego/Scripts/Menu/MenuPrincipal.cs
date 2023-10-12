using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MoreMountains.Feedbacks;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using Unity.VisualScripting;

public class MenuPrincipal : MonoBehaviour
{
        [SerializeField] string level1, menu, creditos;
   
    private void PlayGame(){
       MMSceneLoadingManager.LoadScene(level1);
        
    }
    private void VolverMenu(){
        //SceneManager.LoadScene(0);
        MMSceneLoadingManager.LoadScene(menu);
    }
    private void Creditos(){
        //SceneManager.LoadScene(2);
        MMSceneLoadingManager.LoadScene(creditos);
    }
}
