using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryptor
{
    class CryptDictionary
    {
        private IDictionary<string, long> dict = new Dictionary<string, long>()
        {
            {"a", 1000000007},
            {"b", 1000000009},
            {"c", 1000000021},
            {"d", 1000000033},
            {"e", 1000000087},
            {"f", 1000000093},
            {"g", 1000000097},
            {"h", 10000000537},
            {"i", 1000000123},
            {"j", 1000000181},
            {"k", 1000000207},
            {"l", 1000000223},
            {"m", 1000000241},
            {"n", 1000000271},
            {"o", 1000000289},
            {"p", 1000000297},
            {"q", 1000000321},
            {"r", 1000000349},
            {"s", 1000000363},
            {"t", 1000000403},
            {"u", 1000000019},
            {"v", 10000000679},
            {"w", 1000000061},
            {"x", 1000000069},
            {"y", 1000000063},
            {"z", 1000000103},
            {"0", 832583},
            {"1", 832591},
            {"2", 832597},
            {"3", 832607},
            {"4", 832613},
            {"5", 832621},
            {"6", 832627},
            {"7", 832631},
            {"8", 832633},
            {"9", 832639},
            {" ", 832568003},
            {"!", 832568039},
            {"?", 832568059},
            {".", 832568069},
            {",", 832568071}
        };

        public IDictionary<string, long> encryptionDict()
        {
            return dict;
        }

        public IDictionary<long, string> DecryptionDict()
        {
            return dict.ToDictionary(x => x.Value, x => x.Key);
        }
    }
}
