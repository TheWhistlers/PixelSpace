using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    public GameObject TextPrototype, ButtonPrototype, ImagePrototype;

    public string SelectedLang;
    public static Encoding UTF8 { get; set; } = new UTF8Encoding(false);
    public static string Persistent { get; set; }
    public static Language CurrentLanguage { get; set; }
    public static LocalWorld CurrentWorld { get; set; }
    public const string PREFIX = "pixel";

    private void Awake()
    {
        Persistent = Application.persistentDataPath;

        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

        Languages.Inititalize();
    }

    private void Start()
    {
        Items.Inititalize();

        CurrentLanguage = string.IsNullOrEmpty(SelectedLang) 
            ? Languages.ZH_CN : Registry.LANG.GetByName(SelectedLang);

        new PlayerScreenHandler().Render(new ScreenRenderer(GameObject.Find("Canvas").GetComponent<Canvas>()));
    }
}
