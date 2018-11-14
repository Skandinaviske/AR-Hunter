using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class controlScript : MonoBehaviour {

    AudioSource audio;
    public AudioClip[] clips;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
        StartCoroutine(introJingle());

	}

    private void playSound(int sound) {
        audio.clip = clips[sound];
        audio.Play();
    }

    private IEnumerator introJingle() {
        yield return new WaitForSeconds(3f);
        playSound(0);
        StartCoroutine(quack());
    }
    private IEnumerator quack() {
        yield return new WaitForSeconds(3f);
        playSound(1);
        StartCoroutine(liangsecond());
    }
    private IEnumerator liangsecond() {
        yield return new WaitForSeconds(1.7f);
        playSound(2);
    }
    // Update is called once per frame
    public void ChangeScene () {
        SceneManager.LoadScene("mainbackup2");
	}
}
