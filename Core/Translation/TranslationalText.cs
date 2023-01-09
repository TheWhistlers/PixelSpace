using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TranslationalText : StringText
{
    public TranslationalText(string keyName) : base(keyName) { }

    public override string GetTextContent() =>
        Translator.Translate(GameManager.CurrentLanguage, this.text);
}