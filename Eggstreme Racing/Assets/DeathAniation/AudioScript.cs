using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {
	
	
	public AudioClip Eggscelent ;
	public AudioClip EggsHitting ;
	public AudioClip EggstremeRacing ;
	public AudioClip Eggstroardanary ;
	public AudioClip GentleEggs ;
	public AudioClip Spatula ;
	public AudioClip StartRolling ;

    public AudioClip Player1Wins;
    public AudioClip Player2Wins;
    public AudioClip SpatWeapon;
    public AudioClip PanWeapon;
    public AudioClip DoughWeapon;
	public string audioInput;

	void Start(){
		
		if(audioInput == "Eggscelent")
		{
			audio.clip = Eggscelent;
		}
		if(audioInput == "EggsHitting")
		{
			audio.clip = EggsHitting;
		}
		if(audioInput == "EggstremeRacing")
		{
			audio.clip = EggstremeRacing;
		}
		if(audioInput == "Eggstroardanary")
		{
			audio.clip = Eggstroardanary;
		}
		if(audioInput == "GentleEggs")
		{
			audio.clip = GentleEggs;
		}
		if(audioInput == "Spatula")
		{
			audio.clip = Spatula;
		}
		if(audioInput == "StartRolling")
		{
			audio.clip = StartRolling;
		}

        if (audioInput == "Player1Wins")
        {
            audio.clip = Player1Wins;
        }
        if (audioInput == "Player2Wins")
        {
            audio.clip = Player2Wins;
        }
        if (audioInput == "SpatWeapon")
        {
            audio.clip = SpatWeapon;
        }
        if (audioInput == "PanWeapon")
        {
            audio.clip = PanWeapon;
        }
        if (audioInput == "DoughWeapon")
        {
            audio.clip = DoughWeapon;
        }
		
		
		audio.Play();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(!audio.isPlaying)
		{
			Destroy(this.gameObject);	
		}
	}
}
