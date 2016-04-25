using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

public class Example
{
    public static void Main()
    {
        // Display the header.
        Console.WriteLine("{0,-53}{1}", "CULTURE", "SPECIFIC CULTURE");

        // Get each neutral culture in the .NET Framework.
        CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.NeutralCultures);
        // Sort the returned array by name.
        Array.Sort<CultureInfo>(cultures, new NamePropertyComparer<CultureInfo>());

        // Determine the specific culture associated with each neutral culture.
        foreach (var culture in cultures)
        {
            Console.Write("{0,-12} {1,-40}", culture.Name, culture.EnglishName);
            try
            {
                Console.WriteLine("{0}", CultureInfo.CreateSpecificCulture(culture.Name).Name);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("(no associated specific culture)");
            }
        }
        Console.ReadKey();
    }
}

public class NamePropertyComparer<T> : IComparer<T>
{
    public int Compare(T x, T y)
    {
        if (x == null)
            if (y == null)
                return 0;
            else
                return -1;

        PropertyInfo pX = x.GetType().GetProperty("Name");
        PropertyInfo pY = y.GetType().GetProperty("Name");
        return String.Compare((string)pX.GetValue(x, null), (string)pY.GetValue(y, null));
    }
}

#region Culture&Specific_Culture输出

//            CULTURE SPECIFIC CULTURE
//Invariant Language(Invariant Country)
//aa Afar                                    aa - ET
//af Afrikaans                               af - ZA
//agq Aghem                                   agq - CM
//ak Akan                                    ak - GH
//am Amharic                                 am - ET
//ar Arabic                                  ar - SA
//arn Mapudungun                              arn - CL
//as Assamese as- IN
//asa Asu                                     asa - TZ
//ast Asturian                                ast - ES
//az Azerbaijani                             az - Latn - AZ
//az - Cyrl      Azerbaijani(Cyrillic)                  az - Cyrl - AZ
//az - Latn      Azerbaijani(Latin)                     az - Latn - AZ
//ba Bashkir                                 ba - RU
//bas Basaa                                   bas - CM
//be Belarusian                              be - BY
//bem Bemba                                   bem - ZM
//bez Bena                                    bez - TZ
//bg Bulgarian                               bg - BG
//bin Edo                                     bin - NG
//bm Bamanankan                              bm - Latn - ML
//bm - Latn      Bamanankan(Latin)                      bm - Latn - ML
//bn Bangla                                  bn - IN
//bo Tibetan                                 bo - CN
//br Breton                                  br - FR
//brx Bodo                                    brx - IN
//bs Bosnian                                 bs - Latn - BA
//bs - Cyrl      Bosnian(Cyrillic)                      bs - Cyrl - BA
//bs - Latn      Bosnian(Latin)                         bs - Latn - BA
//byn Blin                                    byn - ER
//ca Catalan                                 ca - ES
//cgg Chiga                                   cgg - UG
//chr Cherokee                                chr - Cher - US
//chr - Cher     Cherokee chr-Cher - US
//co Corsican                                co - FR
//cs Czech                                   cs - CZ
//cy Welsh                                   cy - GB
//da Danish                                  da - DK
//dav Taita                                   dav - KE
//de German                                  de - DE
//dje Zarma                                   dje - NE
//dsb Lower Sorbian dsb-DE
//dua Duala                                   dua - CM
//dv Divehi                                  dv - MV
//dyo Jola-Fonyi                              dyo - SN
//dz Dzongkha                                dz - BT
//ebu Embu                                    ebu - KE
//ee Ewe                                     ee - GH
//el Greek                                   el - GR
//en English                                 en - US
//eo Esperanto                               eo - 001
//es Spanish                                 es - ES
//et Estonian                                et - EE
//eu Basque                                  eu - ES
//ewo Ewondo                                  ewo - CM
//fa Persian                                 fa - IR
//ff Fulah                                   ff - Latn - SN
//ff - Latn      Fulah ff-Latn - SN
//fi Finnish                                 fi - FI
//fil Filipino                                fil - PH
//fo Faroese                                 fo - FO
//fr French                                  fr - FR
//fur Friulian                                fur - IT
//fy Frisian                                 fy - NL
//ga Irish                                   ga - IE
//gd Scottish Gaelic gd-GB
//gl Galician                                gl - ES
//gn Guarani                                 gn - PY
//gsw Alsatian                                gsw - FR
//gu Gujarati                                gu - IN
//guz Gusii                                   guz - KE
//gv Manx                                    gv - IM
//ha Hausa                                   ha - Latn - NG
//ha - Latn      Hausa(Latin)                           ha - Latn - NG
//haw Hawaiian                                haw - US
//he Hebrew                                  he - IL
//hi Hindi                                   hi - IN
//hr Croatian                                hr - HR
//hsb Upper Sorbian hsb-DE
//hu Hungarian                               hu - HU
//hy Armenian                                hy - AM
//ia Interlingua                             ia - FR
//ibb Ibibio                                  ibb - NG
//id Indonesian                              id - ID
//ig Igbo                                    ig - NG
//ii Yi                                      ii - CN
//is Icelandic is- IS
//it Italian                                 it - IT
//iu Inuktitut                               iu - Latn - CA
//iu - Cans      Inuktitut(Syllabics)                   iu - Cans - CA
//iu - Latn      Inuktitut(Latin)                       iu - Latn - CA
//ja Japanese                                ja - JP
//jgo Ngomba                                  jgo - CM
//jmc Machame                                 jmc - TZ
//jv Javanese                                jv - Latn - ID
//jv - Java      Javanese(Javanese)                     jv - Java - ID
//jv - Latn      Javanese jv-Latn - ID
//ka Georgian                                ka - GE
//kab Kabyle                                  kab - DZ
//kam Kamba                                   kam - KE
//kde Makonde                                 kde - TZ
//kea Kabuverdianu                            kea - CV
//khq Koyra Chiini khq-ML
//ki Kikuyu                                  ki - KE
//kk Kazakh                                  kk - KZ
//kkj Kako                                    kkj - CM
//kl Greenlandic                             kl - GL
//kln Kalenjin                                kln - KE
//km Khmer                                   km - KH
//kn Kannada                                 kn - IN
//ko Korean                                  ko - KR
//kok Konkani                                 kok - IN
//kr Kanuri                                  kr - NG
//ks Kashmiri                                ks - Arab - IN
//ks - Arab      Kashmiri(Perso - Arabic)                 ks - Arab - IN
//ksb Shambala                                ksb - TZ
//ks - Deva      Kashmiri(Devanagari)                   ks - Deva - IN
//ksf Bafia                                   ksf - CM
//ksh Ripuarian                               ksh - DE
//ku Central Kurdish ku-Arab - IQ
//ku - Arab      Central Kurdish                         ku - Arab - IQ
//kw Cornish                                 kw - GB
//ky Kyrgyz                                  ky - KG
//la Latin                                   la - 001
//lag Langi                                   lag - TZ
//lb Luxembourgish                           lb - LU
//lg Ganda                                   lg - UG
//lkt Lakota                                  lkt - US
//ln Lingala                                 ln - CD
//lo Lao                                     lo - LA
//lt Lithuanian                              lt - LT
//lu Luba-Katanga                            lu - CD
//luo Luo                                     luo - KE
//luy Luyia                                   luy - KE
//lv Latvian                                 lv - LV
//mas Masai                                   mas - KE
//mer Meru                                    mer - KE
//mfe Morisyen                                mfe - MU
//mg Malagasy                                mg - MG
//mgh Makhuwa-Meetto                          mgh - MZ
//mgo Meta?                                   mgo - CM
//mi Maori                                   mi - NZ
//mk Macedonian                              mk - MK
//ml Malayalam                               ml - IN
//mn Mongolian                               mn - MN
//mn - Cyrl      Mongolian(Cyrillic)                    mn - MN
//mni Manipuri                                mni - IN
//mn - Mong      Mongolian(Traditional Mongolian)       mn - Mong - CN
//moh Mohawk                                  moh - CA
//mr Marathi                                 mr - IN
//ms Malay (Latin)ms - MY
//mt           Maltese                                 mt - MT
//mua          Mundang                                 mua - CM
//my           Burmese                                 my - MM
//naq          Nama                                    naq - NA
//nb           Norwegian Bokm ? l                        nb - NO
//nd           North Ndebele                           nd - ZW
//ne           Nepali                                  ne - NP
//nl           Dutch                                   nl - NL
//nmg          Kwasio                                  nmg - CM
//nn           Norwegian Nynorsk                       nn - NO
//nnh          Ngiemboon                               nnh - CM
//no           Norwegian                               nb - NO
//nqo          N'ko                                    nqo-GN
//nr           South Ndebele                           nr - ZA
//nso          Sesotho sa Leboa                        nso - ZA
//nus          Nuer                                    nus - SS
//nyn          Nyankole                                nyn - UG
//oc           Occitan                                 oc - FR
//om           Oromo                                   om - ET
//or           Odia                                    or - IN
//os           Ossetian                                os - GE
//pa           Punjabi                                 pa - IN
//pa - Arab      Punjabi                                 pa - Arab - PK
//pap          Papiamento                              pap - 029
//pl           Polish                                  pl - PL
//prs          Dari                                    prs - AF
//ps           Pashto                                  ps - AF
//pt           Portuguese                              pt - BR
//quc          K'iche'                                 quc - Latn - GT
//quc - Latn     K'iche'                                 quc - Latn - GT
//quz          Quechua                                 quz - BO
//rm           Romansh                                 rm - CH
//rn           Rundi                                   rn - BI
//ro           Romanian                                ro - RO
//rof          Rombo                                   rof - TZ
//ru           Russian                                 ru - RU
//rw           Kinyarwanda                             rw - RW
//rwk          Rwa                                     rwk - TZ
//sa           Sanskrit                                sa - IN
//sah          Sakha                                   sah - RU
//saq          Samburu                                 saq - KE
//sbp          Sangu                                   sbp - TZ
//sd           Sindhi                                  sd - Arab - PK
//sd - Arab      Sindhi                                  sd - Arab - PK
//sd - Deva      Sindhi(Devanagari)                     sd - Deva - IN
//se           Northern Sami                           se - NO
//seh          Sena                                    seh - MZ
//ses          Koyraboro Senni                         ses - ML
//sg           Sango                                   sg - CF
//shi          Tachelhit                               shi - Tfng - MA
//shi - Latn     Tachelhit(Latin)                       shi - Latn - MA
//shi - Tfng     Tachelhit(Tifinagh)                    shi - Tfng - MA
//si           Sinhala                                 si - LK
//sk           Slovak                                  sk - SK
//sl           Slovenian                               sl - SI
//sma          Sami(Southern)                         sma - SE
//smj          Sami(Lule)                             smj - SE
//smn          Sami(Inari)                            smn - FI
//sms          Sami(Skolt)                            sms - FI
//sn           Shona                                   sn - Latn - ZW
//sn - Latn      Shona(Latin)                           sn - Latn - ZW
//so           Somali                                  so - SO
//sq           Albanian                                sq - AL
//sr           Serbian                                 sr - Latn - RS
//sr - Cyrl      Serbian(Cyrillic)                      sr - Cyrl - RS
//sr - Latn      Serbian(Latin)                         sr - Latn - RS
//ss           siSwati                                 ss - ZA
//ssy          Saho                                    ssy - ER
//st           Sesotho                                 st - ZA
//sv           Swedish                                 sv - SE
//sw           Kiswahili                               sw - KE
//swc          Congo Swahili                           swc - CD
//syr          Syriac                                  syr - SY
//ta           Tamil                                   ta - IN
//te           Telugu                                  te - IN
//teo          Teso                                    teo - UG
//tg           Tajik                                   tg - Cyrl - TJ
//tg - Cyrl      Tajik(Cyrillic)                        tg - Cyrl - TJ
//th           Thai                                    th - TH
//ti           Tigrinya                                ti - ER
//tig          Tigre                                   tig - ER
//tk           Turkmen                                 tk - TM
//tn           Setswana                                tn - ZA
//to           Tongan                                  to - TO
//tr           Turkish                                 tr - TR
//ts           Tsonga                                  ts - ZA
//tt           Tatar                                   tt - RU
//twq          Tasawaq                                 twq - NE
//tzm          Central Atlas Tamazight                 tzm - Latn - DZ
//tzm - Arab     Central Atlas Tamazight(Arabic)        tzm - Arab - MA
//tzm - Latn     Central Atlas Tamazight(Latin)         tzm - Latn - DZ
//tzm - Tfng     Central Atlas Tamazight(Tifinagh)      tzm - Tfng - MA
//ug           Uyghur                                  ug - CN
//uk           Ukrainian                               uk - UA
//ur           Urdu                                    ur - PK
//uz           Uzbek                                   uz - Latn - UZ
//uz - Arab      Uzbek(Perso - Arabic)                    uz - Arab - AF
//uz - Cyrl      Uzbek(Cyrillic)                        uz - Cyrl - UZ
//uz - Latn      Uzbek(Latin)                           uz - Latn - UZ
//vai          Vai                                     vai - Vaii - LR
//vai - Latn     Vai(Latin)                             vai - Latn - LR
//vai - Vaii     Vai(Vai)                               vai - Vaii - LR
//ve           Venda                                   ve - ZA
//vi           Vietnamese                              vi - VN
//vo           Volapük                                 vo - 001
//vun          Vunjo                                   vun - TZ
//wae          Walser                                  wae - CH
//wal          Wolaytta                                wal - ET
//wo           Wolof                                   wo - SN
//xh           isiXhosa                                xh - ZA
//xog          Soga                                    xog - UG
//yav          Yangben                                 yav - CM
//yi           Yiddish                                 yi - 001
//yo           Yoruba                                  yo - NG
//zgh          Standard Moroccan Tamazight             zgh - Tfng - MA
//zgh - Tfng     Standard Moroccan Tamazight(Tifinagh)  zgh - Tfng - MA
//zh           Chinese                                 zh - CN
//zh - CHS       Chinese(Simplified) Legacy             zh - CN
//zh - CHT       Chinese(Traditional) Legacy            zh - HK
//zh - Hans      Chinese(Simplified)                    zh - CN
//zh - Hant      Chinese(Traditional)                   zh - HK
//zu           isiZulu                                 zu - ZA

#endregion Culture&Specific_Culture输出