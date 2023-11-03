using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLanguage : MonoBehaviour
{
	
	public static GameLanguage gl;
	public string currentLanguage = "en";
	
	//Dictionary<string, string> langID; 
	Dictionary<string, string> langES;
	
    // Start is called before the first frame update
    void Start()
    {

        gl = this;
		
		if (PlayerPrefs.HasKey("GameLanguage")) {
            currentLanguage = PlayerPrefs.GetString("GameLanguage");
        }
        else
        {
            ResetLanguage();
        }
		
		Debug.Log("Current language: " + currentLanguage);
		
		WordDefine();
    }

    // Update is called once per frame
    void Update()
    {
		
    }
	
	public void Setlanguage(string langCode)
    {
        PlayerPrefs.SetString("GameLanguage", langCode);
		currentLanguage = langCode;
    }
	
	public void ResetLanguage()
    {
        Setlanguage("en");
    }
	
	public string Say(string text){
		
		switch(currentLanguage){
			/*case "id" :
				return FindInDict(langID, text);*/
			case "es":
				return FindInDict(langES, text);
			default :
				return text;
		}
	}
	
	public string FindInDict(Dictionary<string, string> selectedLang, string text){
		if(selectedLang.ContainsKey(text))
			return selectedLang[text];
		else
			return "Untranslated";
	}
	
	public void WordDefine(){
		
		//Bahasa Indonesia (id)
		/*langID = new Dictionary<string, string>()
		{
			{"English", "Inggris"},
			{"Some word.", "Sebuah kata."},
			{"Choose color", "Pilih warna"},
			{"Indonesian", "Bahasa Indonesia"},
			{"Spanish","Español" },
			{"Reset", "Atur Ulang"},
			{"Reset Language Preference", "Atur Ulang Pengaturan Bahasa"},
			{"Choose Language", "Pilih Bahasa"},
		};*/
		langES = new Dictionary<string, string>()
		{
			{"English", "Ingles"},
			{"Accesibility & Settings", "Accesibilidad & Configuraciones"},
			{"Volume","Volumen"},
            {"Language", "Lenguaje"},
            {"Indonesian", "Indonesio"},
			{"Brightness","Brillo" },
			{"Coding","Programación" },
			{"Credits","Créditos" },
			{"Artists","Artistas" },
			{"Music & SFX","Música & SFX" },
			{"Poster Artist","Artista del Poster" },
			{"Project for school purposes","Proyecto para propósitos escolares" },
			{"Stage Select","Elige tu canción" },
            {"Preview","Elige tu canción" },
            {"Tutorial Song - Max Ibarra","Canción de Tutorial-Max Ibarra"},
			{"YOU Winner","TU GANAS" },
            {"Boss Defeated","Jefe Terminado" },
            {"End of the Practice","Practica terminado" },
            {"Continue","Continuar" },
            {"Retry","Intentar de nuevo" },
			{"You Lose","Tu pierdes" },
			{"Main Menu","Menú Principal" },
			{"Continue Ads","Continuar con Ads" },
			{"Retry Level","Volver a intentar" },
			{"Score","Puntuaje" },
            {"Spanish", "Español"},
            {"Reset", "Resetear"},
            {"Reset Language Preference", "Resetear Idioma"},
            {"Choose Language", "Elije tu idioma"},
        };

    }
		
}
