using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Excel_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char currentLetter;
            long index = 1;
            long code;
            if (n == 1)
            {
                index *= getCode(char.Parse(Console.ReadLine()));
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    currentLetter = char.Parse(Console.ReadLine());
                    code = getCode(currentLetter);
                    if (i == 0)
                    {
                        index = code * 26;
                    }
                    else
                    {
                        index += code;
                        if (i < n - 1)
                        {
                            index *= 26;
                        }
                    }
                }
            }
            Console.WriteLine(index);
        }

        private static int getCode(char currentLetter)
        {
            switch (currentLetter)
            {
                case 'A': return 1;
                case 'B': return 2;
                case 'C': return 3;
                case 'D': return 4;
                case 'E': return 5;
                case 'F': return 6;
                case 'G': return 7;
                case 'H': return 8;
                case 'I': return 9;
                case 'J': return 10;
                case 'K': return 11;
                case 'L': return 12;
                case 'M': return 13;
                case 'N': return 14;
                case 'O': return 15;
                case 'P': return 16;
                case 'Q': return 17;
                case 'R': return 18;
                case 'S': return 19;
                case 'T': return 20;
                case 'U': return 21;
                case 'V': return 22;
                case 'W': return 23;
                case 'X': return 24;
                case 'Y': return 25;
                case 'Z': return 26;
                default: return -1;
            }

        }
    }
}
//char[] letter = Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (Char)i).ToArray();
//case "aA": Console.WriteLine(26); break;
//case "aB": Console.WriteLine(27); break;
//case "aC": Console.WriteLine(28); break;
//case "aD": Console.WriteLine(29); break;
//case "aE": Console.WriteLine(30); break;
//case "aF": Console.WriteLine(31); break;
//case "aG": Console.WriteLine(32); break;
//case "aH": Console.WriteLine(33); break;
//case "aI": Console.WriteLine(34); break;
//case "aJ": Console.WriteLine(35); break;
//case "aK": Console.WriteLine(36); break;
//case "aL": Console.WriteLine(37); break;
//case "aM": Console.WriteLine(38); break;
//case "aN": Console.WriteLine(39); break;
//case "aO": Console.WriteLine(40); break;
//case "aP": Console.WriteLine(41); break;
//case "aQ": Console.WriteLine(42); break;
//case "aR": Console.WriteLine(43); break;
//case "aS": Console.WriteLine(44); break;
//case "aT": Console.WriteLine(45); break;
//case "aU": Console.WriteLine(46); break;
//case "aV": Console.WriteLine(47); break;
//case "aW": Console.WriteLine(48); break;
//case "aX": Console.WriteLine(49); break;
//case "aY": Console.WriteLine(50); break;
//case "aZ": Console.WriteLine(51); break;
//case "bA": Console.WriteLine(52); break;
//case "bB": Console.WriteLine(53); break;
//case "bC": Console.WriteLine(54); break;
//case "bD": Console.WriteLine(55); break;
//case "bE": Console.WriteLine(56); break;
//case "bF": Console.WriteLine(57); break;
//case "bG": Console.WriteLine(58); break;
//case "bH": Console.WriteLine(59); break;
//case "bI": Console.WriteLine(60); break;
//case "bJ": Console.WriteLine(61); break;
//case "bK": Console.WriteLine(62); break;
//case "bL": Console.WriteLine(63); break;
//case "bM": Console.WriteLine(64); break;
//case "bN": Console.WriteLine(65); break;
//case "bO": Console.WriteLine(66); break;
//case "bP": Console.WriteLine(67); break;
//case "bQ": Console.WriteLine(68); break;
//case "bR": Console.WriteLine(69); break;
//case "bS": Console.WriteLine(70); break;
//case "bT": Console.WriteLine(71); break;
//case "bU": Console.WriteLine(72); break;
//case "bV": Console.WriteLine(73); break;
//case "bW": Console.WriteLine(74); break;
//case "bX": Console.WriteLine(75); break;
//case "bY": Console.WriteLine(76); break;
//case "bZ": Console.WriteLine(77); break;
//case "cA": Console.WriteLine(78); break;
//case "cB": Console.WriteLine(79); break;
//case "cC": Console.WriteLine(80); break;
//case "cD": Console.WriteLine(81); break;
//case "cE": Console.WriteLine(82); break;
//case "cF": Console.WriteLine(83); break;
//case "cG": Console.WriteLine(84); break;
//case "cH": Console.WriteLine(85); break;
//case "cI": Console.WriteLine(86); break;
//case "cJ": Console.WriteLine(87); break;
//case "cK": Console.WriteLine(88); break;
//case "cL": Console.WriteLine(89); break;
//case "cM": Console.WriteLine(90); break;
//case "cN": Console.WriteLine(91); break;
//case "cO": Console.WriteLine(92); break;
//case "cP": Console.WriteLine(93); break;
//case "cQ": Console.WriteLine(94); break;
//case "cR": Console.WriteLine(95); break;
//case "cS": Console.WriteLine(96); break;
//case "cT": Console.WriteLine(97); break;
//case "cU": Console.WriteLine(98); break;
//case "cV": Console.WriteLine(99); break;
//case "cW": Console.WriteLine(100); break;
//case "cX": Console.WriteLine(101); break;
//case "cY": Console.WriteLine(102); break;
//case "cZ": Console.WriteLine(103); break;
//case "dA": Console.WriteLine(104); break;
//case "dB": Console.WriteLine(105); break;
//case "dC": Console.WriteLine(106); break;
//case "dD": Console.WriteLine(107); break;
//case "dE": Console.WriteLine(108); break;
//case "dF": Console.WriteLine(109); break;
//case "dG": Console.WriteLine(110); break;
//case "dH": Console.WriteLine(111); break;
//case "dI": Console.WriteLine(112); break;
//case "dJ": Console.WriteLine(113); break;
//case "dK": Console.WriteLine(114); break;
//case "dL": Console.WriteLine(115); break;
//case "dM": Console.WriteLine(116); break;
//case "dN": Console.WriteLine(117); break;
//case "dO": Console.WriteLine(118); break;
//case "dP": Console.WriteLine(119); break;
//case "dQ": Console.WriteLine(120); break;
//case "dR": Console.WriteLine(121); break;
//case "dS": Console.WriteLine(122); break;
//case "dT": Console.WriteLine(123); break;
//case "dU": Console.WriteLine(124); break;
//case "dV": Console.WriteLine(125); break;
//case "dW": Console.WriteLine(126); break;
//case "dX": Console.WriteLine(127); break;
//case "dY": Console.WriteLine(128); break;
//case "dZ": Console.WriteLine(129); break;