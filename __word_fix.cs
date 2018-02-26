using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTranslateLOG
{

    public static class __word_fix
    {
        private static Dictionary<string, string> dic = new Dictionary<string, string>() {
            { " t ime"," time"},
            { " fi nished"," finished"},
            { " ta lk"," talk "},
            { " t ruth"," truth"},
            { " t hing"," thing"},
        };
        public static ReadOnlyDictionary<string, string> MapWordReplace = new ReadOnlyDictionary<string, string>(dic);
    }
}
