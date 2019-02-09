using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class load : MonoBehaviour {
public Vector3 position;
	public PlayerData playerData;
string FilePath;
	// Use this for initialization
	void Start () {
		FilePath=Path.Combine(Application.dataPath,"save.txt");
		carrega();
	}
	
	// Update is called once per frame
	void Update () {
		carrega();
	}

	void carrega(){
		string jsonstring=File.ReadAllText(FilePath);
		playerData = JsonUtility.FromJson<PlayerData>(jsonstring);
		print(playerData.posicaocasa);
		//position=playerData.posicaocasa();
	}
}
