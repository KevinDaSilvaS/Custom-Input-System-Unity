using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class SaveLoad : MonoBehaviour {
public PlayerData playerData;
string FilePath;
	// Use this for initialization
	void Start () {
		FilePath=Path.Combine(Application.dataPath,"save.txt");
		save();
	}
	
	// Update is called once per frame
	void Update () {
		save();
	}

	void save(){
		string jsonstring=JsonUtility.ToJson(playerData);
		File.WriteAllText(FilePath,jsonstring);
	}

	void load(){

	}
}