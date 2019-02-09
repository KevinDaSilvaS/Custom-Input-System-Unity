using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class cenateste : MonoBehaviour {
	public Custom_Input_Data playerData;
 string FilePath;
 public KeyCode botaomovimentarcima;
	// Use this for initialization
	void Start () {
		 FilePath=Path.Combine(Application.dataPath,"inputData.txt");
		carrega();
	}
	
	// Update is called once per frame
	void Update () {
		
			if (Input.GetKeyDown(botaomovimentarcima))
        {
            print("space key was pressed"+botaomovimentarcima);
        }
		
		
	}

	 void carrega(){
		string jsonstring=File.ReadAllText(FilePath);
		playerData = JsonUtility.FromJson<Custom_Input_Data>(jsonstring);
        botaomovimentarcima=playerData.teclaselecionada;
		//print(playerData.posicaocasa);
		//position=playerData.posicaocasa();
	}
}

