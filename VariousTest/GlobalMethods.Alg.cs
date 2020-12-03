using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VariousTest
{
    public static partial class GM
    {
        static public string NumberToText(int number)
        {
            string strNum = number.ToString();
            if (strNum.Length>9)    // algoritmus je napsany pro cisla 1 - 999 999 999
                return strNum;

            string[] arrJedn = {"",       "jedna",      "dvě",        "tři",         "čtyři",        "pět",        "šest",        "sedm",        "osm",        "devět"};
            string[] arrDes  = {"",       "",           "dvacet",     "třicet",      "čtyřicet",     "padesát",    "šedesát",     "sedmdesát",   "osmdesát",   "devadesát"};
            string[] arrDes2 = {"deset",  "jedenáct",   "dvanáct",    "třináct",     "čtrnáct",      "patnáct",    "šestnáct",    "sedmnáct",    "osmnáct",    "devatenáct"};
            string[] arrSto  = {"",       "sto",        "dvěstě",     "třista",      "čtyřista",     "pětset",     "šestset",     "sedmset",     "osmset",     "devětset"};
            string[] arrTis  = {"tisíc",  "jeden tisíc","dva tisíce", "tři tisíce",  "čtyři tisíce", "pět tisíc",  "šest tisíc",  "sedm tisíc",  "osm tisíc",  "devět tisíc"};
            string[] arrMil  = {"milionů","jeden milion","dva miliony","tři miliony","čtyři miliony","pět milionů","šest milionů","sedm milionů","osm milionů","devět milionů"};

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i<strNum.Length; i++)
            {
                if ( sb.Length > 0 && sb[sb.Length-1] != ' ' )
                    sb.Append(' ');

                int val = (int)(strNum[i]-'0');
                if ( val < 0 || val > 9 )
                    continue;

                int pos = strNum.Length-1-i;
                switch ( pos )
                {
                case 0: sb.Append(arrJedn[val]); break; // jednotky
                case 3: if ( val != 0 || strNum.Length<7 || strNum[i-1]!='0' || strNum[i-2]!='0') sb.Append(arrTis[val]); break;// podminka vylucujici pridani slova tisic pokud je cislo >= milion a nejsou v nem tisice 
                case 6: sb.Append(arrMil[val]); break;  // miliony
                case 2:
                case 5:
                case 8: sb.Append(arrSto[val]); break;  // stovky, stovky tisic nebo stovky milionu
                case 1:
                case 4:
                case 7:                                 // desitky, desitky tisic nebo desitky milionu
                    if ( val == 1 ) 
                    {
                        i++;    // u cisel 10 az 19 preskoc tuto pozici a rozhodni podle dalsi pozice
                        sb.Append(arrDes2[(int)(strNum[i]-'0')]);
                        // dopln rad
                        if ( pos == 4 ) sb.Append(" "+arrTis[0]); //  tisic
                        else if( pos == 7 ) sb.Append(" "+arrMil[0]); //  milionu
                    }
                    else
                        sb.Append(arrDes[val]);
                    break;
                }
            }

            return sb.ToString().Trim();
/* kratsi varianta na zapis, ale s duplikovanymi retezci
            string[][] arrHlp = {  new string[] {"",     "jedna","dvě",      "tři",      "čtyři",      "pět",     "šest",     "sedm",     "osm",     "devět"},
                                   new string[] {"",     "",     "dvacet",   "třicet",   "čtyřicet",   "padesát", "šedesát",  "sedmdesát","osmdesát","devadesát"},
                                   new string[] {"",     "sto",  "dvěstě",   "třista",   "čtyřista",   "pětset",  "šestset",  "sedmset",  "osmset",  "devětset"},
                                   new string[] {"tisíc","jeden tisíc","dva tisíce","tři tisíce","čtyři tisíce", "pět tisíc", "šest tisíc","sedm tisíc","osm tisíc","devět tisíc"},
                                   new string[] {"",     "",     "dvacet",   "třicet",   "čtyřicet",   "padesát", "šedesát",  "sedmdesát","osmdesát","devadesát"},
                                   new string[] {"",     "sto",  "dvěstě",   "třista",   "čtyřista",   "pětset",  "šestset",  "sedmset",  "osmset",  "devětset"},
                                   new string[] {"milionů", "jeden milion","dva miliony", "tři miliony ", "čtyři miliony ","pět milionů", "šest milionů", "sedm milionů", "osm milionů", "devět milionů"},
                                   new string[] {"",     "",     "dvacet",   "třicet",   "čtyřicet",   "padesát", "šedesát",  "sedmdesát","osmdesát","devadesát"},
                                   new string[] {"",     "sto",  "dvěstě",   "třista",   "čtyřista",   "pětset",  "šestset",  "sedmset",  "osmset",  "devětset"}  };
            string[] arrHlp2 = {"deset","jedenáct","dvanáct","třináct","čtrnáct","patnáct","šestnáct","sedmnáct","osmnáct","devatenáct"};

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i<strNum.Length; i++)
            {
                if ( sb.Length > 0 && sb[sb.Length-1] != ' ' )
                    sb.Append(' ');

                int val = (int)(strNum[i]-'0');
                if ( val < 0 || val > 9 )
                   continue;
                int pos = strNum.Length-1-i;
                if ( (pos==1 || pos==4 || pos==7) && val==1 )
                {
                    i++;    // u cisel 10 az 19 preskoc tuto pozici a rozhodni podle dalsi pozice
                    sb.Append(arrHlp2[(int)(strNum[i]-'0')]);
                    if ( pos > 1 ) 
                        sb.Append(" "+arrHlp[pos-1][0]); // tisic, milionu
                }
                else if ( pos != 3 || val != 0 || strNum.Length<7 || strNum[i-1]!='0' || strNum[i-2]!='0' ) // podminka vylucujici pridani slova tisic pokud je cislo >= milion a nejsou v nem tisice 
                    sb.Append(arrHlp[pos][val]);
            }

            return sb.ToString().Trim();
 */ 
        }
        static public List<String> WrapText(string text, int maxLineLength)
        {
            List<String> arrLines = new List<string>();
            if ( string.IsNullOrEmpty(text) || maxLineLength < 1 )
                return arrLines;

            StringBuilder sb = new StringBuilder(text);
            sb.Replace("\t", " ");
            sb.Replace("\r", " ");
            sb.Replace("\n", " ");
            sb.Replace("  ", " ");

            for(int end = 0; end < sb.Length; )
            {
                int start = end;
                // najdi zacatek radky - orizni prazne znaky na zacatku radky
                while ( start < sb.Length && char.IsWhiteSpace(sb[start]) )
                    start++;

                // najdi konec radky
                end = start+maxLineLength;
                if ( end >= sb.Length ) // posledni radka v textu
                    end = sb.Length;
                else
                {
                    while ( end>start && !char.IsWhiteSpace(sb[end]) )  // najdi posledni oddelovac na radce
                        end--;
                    if ( end == start ) // v radce neni oddelovac, jako radku ber maxLineLength znaku
                        end = start+maxLineLength;
                }
                // pridej radku do seznamu
                if ( end > start )
                    arrLines.Add(sb.ToString(start, end-start).TrimEnd());
            }

            return arrLines;
        }
        static public string CutDiactric(string s)
        {
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                    sb.Append(stFormD[ich]);
            }
            return sb.ToString();
        }
        // kontrolni algoritmus ICO - pocita se odzadu s vynechanim posledni (kontrolni) cislice:
        // predposledni*2+ta pred ni*3+jeste pred tim*4 ... - takto vznikly
        // vysledek vezmeme modulo 11,
        // odecteme od jedenactky a mela by vzniknout posledni, kontrolni cislice.
        // Pokud vyjde 10 je kontrolni cislice 0.
        // Pro ICO 18826342 je to tedy 4*2+3*3+6*4+2*5+8*6+8*7+1*8=163
        // 163=9 (mod 11) a 11-9=2 - kontrolni cislice je 2
        static public bool CheckCID(string CID)
        {
	        int checkSum = 0;
	        for ( int i = CID.Length-2; i>=0; i-- )
		        checkSum += (CID[i]-('0')) * (CID.Length-i);

	        int rest = 11 - checkSum % 11;
	        if ( rest >= 10 )
		        rest -= 10;

	        return ( CID[CID.Length-1] - '0' == rest );
        }

    }
}
