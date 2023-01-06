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
    public static string Prefix = "pixel";

    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;

        Persistent = Application.persistentDataPath;
        CurrentLanguage = Registry.LANG.Contents.Where(l => l.Name.Equals(SelectedLang)) as Language;

        new PlayerScreenHandler().Render(new ScreenRenderer(GameObject.Find("Canvas").GetComponent<Canvas>()));
    }
}
