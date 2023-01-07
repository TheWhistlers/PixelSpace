using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TranslationalText : TextBase
{
    public TranslationalText(string keyName) : base(keyName) { }

    public string TranslatedText(Language language) =>
        Translator.Translate(language, this.KeyName);
}