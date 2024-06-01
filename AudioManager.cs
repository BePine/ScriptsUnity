using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	[SerializeField] AudioSource musicSource;
	[SerializeField] AudioSource SFXSource;

	public AudioClip background;
	public AudioClip death;
	public AudioClip run;
	public AudioClip wallTouch;
	public AudioClip jump;
	public AudioClip startWalking;
	public AudioClip fallOnGround;
	public AudioClip attack;



	private void Start()
	{
		musicSource.clip = background;
		musicSource.volume = (float)0.15;
		musicSource.Play();
	}
	public bool PlaySFX(AudioClip clip)
	{
		SFXSource.PlayOneShot(clip);
		return true;
	}
}
