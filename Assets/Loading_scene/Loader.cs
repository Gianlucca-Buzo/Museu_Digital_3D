using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public static class Loader
{
    public enum Scene{
        Level01,
        Loading_Scene,
    }

    private static Action onLoaderCallBack;
   public static void load(Scene scene){
       onLoaderCallBack = () => {
        SceneManager.LoadScene(Scene.Loading_Scene.ToString());
       };

       SceneManager.LoadScene(scene.ToString());
   }

   public static void LoaderCallBack(){
       if(onLoaderCallBack != null){
           onLoaderCallBack();
           onLoaderCallBack = null;
       }
   }
}
