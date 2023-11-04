using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLanguage : MonoBehaviour
{
	
	public static GameLanguage gl;
	public string currentLanguage = "en";
	public bool currentLang = true;
	
	//Dictionary<string, string> langID; 
	Dictionary<string, string> langES;
	
    // Start is called before the first frame update
    void Start()
    {
        currentLang = (PlayerPrefs.GetInt("Name") != 0);

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

	public void SetActive()
	{
        currentLang = true;
        PlayerPrefs.SetInt("Idioma", (currentLang ? 1 : 0));
		
	}

	public void SetFalse()
	{
		currentLang = false;
        PlayerPrefs.SetInt("Idioma", (currentLang ? 1 : 0));
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
			{"Coding","Programacion" },
			{"Credits","Creditos" },
			{"Artists","Artistas" },
			{"Music & SFX","Música & SFX" },
			{"Poster Artist","Artista del Poster" },
			{"Project for school purposes","Proyecto para propositos escolares" },
			{"Stage Select","Elige tu cancion" },
            {"Preview","Elige tu canción" },
            {"Tutorial Song - Max Ibarra","Canción de Tutorial-Max Ibarra"},
			{"YOU Winner","TU GANAS" },
            {"Boss Defeated","Jefe Terminado" },
            {"End of the Practice","Practica terminado" },
            {"Continue","Continuar" },
            {"Retry","De nuevo" },
			{"You Lose","Tu pierdes" },
			{"Main Menu","Menu Principal" },
			{"Continue Ads","Continuar con Ads" },
			{"Retry Level","De nuevo" },
			{"High Score","Mayor Puntuacion" },
			{"Score","Puntuaje" },
            {"Spanish", "Espanol"},
            {"Reset", "Resetear"},
            {"Reset Language Preference", "Resetear Idioma"},
            {"Choose Language", "Elije tu idioma"},
        };

    }
		
}
