using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LEVEVLLOADER : MonoBehaviour
{
	
    public GameObject loadingScreen;
    public Slider slider;
	
    public void LoadLevel(int index){
    Debug.Log("click");
    	StartCoroutine(loadasync(index));
    }
    
    IEnumerator loadasync (int index){
    	AsyncOperation operation = SceneManager.LoadSceneAsync(index);
    	
    	loadingScreen.SetActive(true);
    	
    	while(!operation.isDone){
    		float prog = Mathf.Clamp01(operation.progress/ .9f);
    		slider.value = prog;
    		yield return null;
    	}
    }
}
