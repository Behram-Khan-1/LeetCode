public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        int totalLength = s.Length - 1;
        int lastIndex = s.Length - 1;
        int secondLastIndex = s.Length - 2;

        Dictionary<string, int> dictionary = new Dictionary<string, int> {
            {"I", 1}, {"V", 5}, {"X", 10}, {"L", 50}, {"C", 100}, {"D", 500}, {"M", 1000}
        };

        while (lastIndex >= 0) {
            int x = Compare(s, dictionary, lastIndex);

            if (secondLastIndex > 0) {
                int y = Compare(s, dictionary, secondLastIndex);

                if (y > x) {
                    result += y + x;
                    lastIndex -= 2;
                    secondLastIndex -= 2;
                    continue;
                }

                if (y < x) {
                    result += x - y;
                    lastIndex -= 2;
                    secondLastIndex -= 2;
                    continue;
                }
            }

            result += x;
            lastIndex -= 1;
            secondLastIndex -= 1;
        }

        return result;
    }

    private int Compare(string s, Dictionary<string, int> dictionary, int lastIndex) {
        switch (s[lastIndex]) {
            case 'I': return dictionary["I"];
            case 'V': return dictionary["V"];
            case 'X': return dictionary["X"];
            case 'L': return dictionary["L"];
            case 'C': return dictionary["C"];
            case 'D': return dictionary["D"];
            case 'M': return dictionary["M"];
            default: return 0;
        }
    }
}