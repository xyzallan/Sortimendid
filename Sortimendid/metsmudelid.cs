using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Sortimendid
{

    struct Sorts
    {
        public double vjp;
        public double vpp;
        public double vpa;
        public double vky;
        public double vjt;
        public double vko;
    }

    struct Sdiam
    {
        public double Djp;
        public double Dpp;
        public double Dpa;
        public double Dky;
        
    }

    
    class metsmudelid
    {

        public static double Tagavara(string Puuliik, double Korgus, double Rinnaspindala)
        {
            double Tgvr = 0;

            switch (Puuliik)
            {
                case "MA":
                case "SD":
                case "LH":
                    if (Korgus >= 6 & Korgus < 50)
                    {
                        Tgvr = (-0.2934 + 4.0350 / Korgus + -0.1204 * Math.Sqrt(Korgus) + 0.3704 * Math.Log(Korgus)) * Korgus * Rinnaspindala;

                    }
                    break;
                case "KU":
                case "TS":
                    if (Korgus >= 6 & Korgus < 50)
                    {
                        Tgvr = (0.9672 + 0.4713 / Korgus + 0.0992 * Math.Sqrt(Korgus) + -0.3109 * Math.Log(Korgus)) * Korgus * Rinnaspindala;

                    }
                    break;

                case "KS":
                case "PN":
                    if (Korgus >= 6 & Korgus < 50)
                    {
                        Tgvr = (-1.6715 + 7.5641 / Korgus + -0.3429 * Math.Sqrt(Korgus) + 1.1006 * Math.Log(Korgus)) * Korgus * Rinnaspindala;

                    }
                    break;

                case "HB":
                case "LM":
                case "LV":
                case "RE":
                    if (Korgus >= 6 & Korgus < 50)
                    {
                        Tgvr = (0.8813 + -0.5950 / Korgus + 0.0437 * Math.Sqrt(Korgus) + -0.1969 * Math.Log(Korgus)) * Korgus * Rinnaspindala;

                    }
                    break;

                default:
                    if (Korgus >= 6 & Korgus < 50)
                    {
                        Tgvr = (0.5993 + 0.9350 / Korgus + 0.0286 * Math.Sqrt(Korgus) + -0.1006 * Math.Log(Korgus)) * Korgus * Rinnaspindala;

                    }
                    break;

            }

            return Math.Round(Tgvr, 1);
        }

        public static double SortMaht(string Pl, double p_d, double p_h, double sek_alg, double sek_lop)
        {
            double pi = 3.1415926535;
            if (p_h <= 1.3) p_d = 0;

            double cf6 = 752.018; double cf5 = -2212.940; double cf4 = 2606.605;
            double cf3 = -1643.304; double cf2 = 530.481; double cf1 = -143.288; double cf0 = 110.428;
            double cf8 = 0.0074; double cf9 = 18; double cf10 = 0.0002; double cf11 = 20;

            if ((Pl == "KP") | (Pl == "JA") | (Pl == "VA") | (Pl == "TA"))
            {
                cf6 = 2971.333; cf5 = -9254.632; cf4 = 11231.250; cf3 = -6736.346;
                cf2 = 2022.206; cf1 = -354.769; cf0 = 120.958;
                cf8 = 0.0263; cf9 = 14; cf10 = 0.0005; cf11 = 20;
            }

            if (Pl == "SA")
            {
                cf6 = 2506.62; cf5 = -7175.007; cf4 = 7964.660; cf3 = -4542.395;
                cf2 = 1411.064; cf1 = -282.941; cf0 = 117.999;
                cf8 = 0.0000; cf9 = 20; cf10 = -0.0021; cf11 = 21;
            }

            if (Pl == "LV")
            {
                cf6 = 626.131; cf5 = -2137.684; cf4 = 3045.214;
                cf3 = -2376.874; cf2 = 988.135; cf1 = -263.482; cf0 = 118.560;
                cf8 = 0.0168; cf9 = 16; cf10 = -0.0103; cf11 = 16;
            }

            if (Pl == "LM")
            {
                cf6 = 1743.640; cf5 = -5408.312; cf4 = 6644.011;
                cf3 = -4238.703; cf2 = 1450.125; cf1 = -310.985; cf0 = 120.224;
                cf8 = 0.0264; cf9 = 14; cf10 = -0.0017; cf11 = 12;
            }

            if (Pl == "KS")
            {
                cf6 = 1120.891; cf5 = -3788.858; cf4 = 5197.005;
                cf3 = -3725.819; cf2 = 1388.288; cf1 = -312.074; cf0 = 120.567;
                cf8 = 0.0210; cf9 = 20; cf10 = 0.0000; cf11 = 28;
            }

            if ((Pl == "NU") | (Pl == "TS") | (Pl == "KU"))
            {
                cf6 = 390.755; cf5 = -1699.667; cf4 = 2732.076; cf3 = -2161.251;
                cf2 = 827.209; cf1 = -203.061; cf0 = 113.939;
                cf8 = 0.0087; cf9 = 33; cf10 = -0.0097; cf11 = 36;
            }

            if ((Pl == "TO") | (Pl == "SD") | ( Pl == "LH") | (Pl == "MA"))
            {
                cf6 = 997.657; cf5 = -3361.780; cf4 = 4419.682; cf3 = -3037.487;
                cf2 = 1140.525; cf1 = -277.578; cf0 = 118.981;
                cf8 = 0.0070; cf9 = 26; cf10 = -0.0070; cf11 = 30;
            }


            double abi1 = 1.3 / p_h;
            double abi2 = (((((cf6 * abi1 + cf5) * abi1 + cf4) * abi1 + cf3) * abi1 + cf2) * abi1 + cf1) * abi1 + cf0;
            double abi3 = cf8 * (p_h - cf9) + cf10 * (p_d - cf11);
            double abi4 = 1 - 0.01 * abi3;
            double c1 = abi4 * cf0;
            double c2 = abi4 * cf1 / p_h;
            double c3 = (abi4 * cf2 + abi3 * cf0) / Math.Pow(p_h, 2);
            double c4 = (abi4 * cf3 + abi3 * cf1) / Math.Pow(p_h, 3);
            double c5 = (abi4 * cf4 + abi3 * cf2) / Math.Pow(p_h, 4);
            double c6 = (abi4 * cf5 + abi3 * cf3) / Math.Pow(p_h, 5);
            double c7 = (abi4 * cf6 + abi3 * cf4) / Math.Pow(p_h, 6);
            double c8 = abi3 * cf5 / Math.Pow(p_h, 7);
            double c9 = abi3 * cf6 / Math.Pow(p_h, 8);
            double d1 = c1 * c1;
            double d2 = c1 * c2;
            double d3 = (c2 * c2 + 2 * c1 * c3) / 3;
            double d4 = (c1 * c4 + c2 * c3) / 2;
            double d5 = (c3 * c3 + 2 * c2 * c4 + 2 * c1 * c5) / 5;
            double d6 = (c1 * c6 + c2 * c5 + c3 * c4) / 3;
            double d7 = (c4 * c4 + 2 * c3 * c5 + 2 * c2 * c6 + 2 * c1 * c7) / 7;
            double d8 = (c1 * c8 + c2 * c7 + c3 * c6 + c4 * c5) / 4;
            double d9 = (c5 * c5 + 2 * c4 * c6 + 2 * c3 * c7 + 2 * c2 * c8 + 2 * c1 * c9) / 9;
            double d10 = (c2 * c9 + c3 * c8 + c4 * c7 + c5 * c6) / 5;
            double d11 = (c6 * c6 + 2 * c5 * c7 + 2 * c4 * c8 + 2 * c3 * c9) / 11;
            double d12 = (c4 * c9 + c5 * c8 + c6 * c7) / 6;
            double d13 = (c7 * c7 + 2 * c6 * c8 + 2 * c5 * c9) / 13;
            double d14 = (c6 * c9 + c7 * c8) / 7;
            double d15 = (c8 * c8 + 2 * c7 * c9) / 15;
            double d16 = c8 * c9 / 8;
            double d17 = (c9 * c9) / 17;
            double abi5 = ((((((((((((((((d17 * sek_alg + d16) * sek_alg + d15) * sek_alg + d14) * sek_alg + d13) * sek_alg +
                +d12) * sek_alg + d11) * sek_alg + d10) * sek_alg + d9) * sek_alg + d8) * sek_alg + d7) * sek_alg +
                +d6) * sek_alg + d5) * sek_alg + d4) * sek_alg + d3) * sek_alg + d2) * sek_alg + d1) * sek_alg;
            double abi6 = ((((((((((((((((d17 * sek_lop + d16) * sek_lop + d15) * sek_lop + d14) * sek_lop + d13) * sek_lop +
                +d12) * sek_lop + d11) * sek_lop + d10) * sek_lop + d9) * sek_lop + d8) * sek_lop + d7) * sek_lop +
                +d6) * sek_lop + d5) * sek_lop + d4) * sek_lop + d3) * sek_lop + d2) * sek_lop + d1) * sek_lop;
            double v = (abi6 - abi5) * p_d * p_d * pi / Math.Pow(((1 + (abi1 * abi1 - 0.01) * abi3) * abi2), 2) / 40000;

            return Math.Round(v, 6);

        }

        public static Sorts SortJaot(string Pl, double p_d, double p_h, 
                double Kahj_ulat, double Kahj_aste, double Kahj_prots, Sdiam MinDiams)
        {

            Sorts tulem = new Sorts();
            
            double sd, n, nn = 0, sh, yp, koor, kand;
            double dx, hx, dxs;
            double[] dd = { 0, 0, 0, 21, 47, 69, 89, 100, 108, 107, 102, 91, 77, 60, 45, 31, 22, 16, 9, 4, 2 };
            double Kh = p_h / KorgKover(Pl, p_d);

            double sjm = 0, sjmkahj = 0;

            for (int sds = 3; sds <= 20; sds++)
            {

                sd = p_d * (double)sds / 10;
                n = dd[sds];
                nn = nn + n;
                sh = Kh * KorgKover(Pl, sd);
                yp = SortMaht(Pl, sd, sh, 0, sh);

                tulem.vko = tulem.vko + yp * n;

                koor = KooreProtsent(Pl, sd);
                
                if (sd <= 30)
                    { kand = 0.1 + sh / 300; }
                else
                    { kand = sd / 300 + sh / 300; }

                if ((sh >= 5) & (sd >= 8))
                {
                    for (hx = kand + 3.1; hx <= sh; hx = hx + 3.1)
                    {
                        dx = ozol_D(Pl, sd, sh, hx);
                        dxs = dx / Math.Pow(1 + koor, 0.5);

                        if (MinDiams.Djp <= dxs)
                        {
                            sjm = SortMaht(Pl, sd, sh, hx - 3, hx) * n * (1 - koor);
                            sjmkahj = sjm * (1 - Kahj_prots / 100);

                            if (Kahj_ulat >= hx - 1)
                            {
                                if (Kahj_aste == 0.5)
                                {
                                    tulem.vpa = tulem.vpa + sjmkahj;
                                    tulem.vjp = tulem.vjp + sjm - sjmkahj;
                                }
                                else
                                {
                                    tulem.vky = tulem.vky + sjmkahj;
                                    tulem.vjp = tulem.vjp + sjm - sjmkahj;
                                }
                            }
                            else
                            {
                                tulem.vjp = tulem.vjp + sjm;
                            }
                        }
                        else if (MinDiams.Dpp <= dxs)
                        {
                            sjm = SortMaht(Pl, sd, sh, hx - 3, hx) * n * (1 - koor);
                            sjmkahj = sjm * (1 - Kahj_prots / 100);

                            if (Kahj_ulat >= hx - 1)
                            {
                                if (Kahj_aste == 0.5)
                                {
                                    tulem.vpa = tulem.vpa + sjmkahj;
                                    tulem.vjp = tulem.vjp + sjm - sjmkahj;
                                }
                                else
                                {
                                    tulem.vky = tulem.vky + sjmkahj;
                                    tulem.vjp = tulem.vjp + sjm - sjmkahj;
                                }
                            }
                            else
                            {
                                tulem.vpp = tulem.vpp + sjm;
                            }

                        }

                        else if (MinDiams.Dpa <= dxs)
                        {
                            sjm = SortMaht(Pl, sd, sh, hx - 3.1, hx - 0.1) * n * (1 - koor);
                            tulem.vpa = tulem.vpa + sjm;
                            hx = hx - 0.1;
                        }
                        else if (MinDiams.Dky <= dxs)
                        {
                            sjm = SortMaht(Pl, sd, sh, hx - 3.1, hx - 0.1) * n * (1 - koor);
                            tulem.vky = tulem.vky + sjm;
                            hx = hx - 0.1;
                        }



                    }

                }

            }


            tulem.vjt = tulem.vko - (tulem.vjp + tulem.vpp + tulem.vpa + tulem.vky);

            return tulem;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Pl"></param>
        /// <param name="D"></param>
        /// <returns></returns>
        public static double KorgKover(string Pl, double D)
        {
            double c1 = 31.985;
            double c2 = 8.0;
            double c3 = 1.4625;

            if ((Pl == "KP") | (Pl == "JA") | (Pl == "VA") | (Pl == "SA") | (Pl == "KP"))
            {
                c1 = 35.8659;
                c2 = 1.6;
                c3 = 8.2934;
            }
            if ((Pl == "PN") | (Pl == "RE") | (Pl == "LV") | (Pl == "LM"))
            {
                c1 = 31.6953;
                c2 = 4.3;
                c3 = 2.4979;
            }

            if ((Pl == "SD") | (Pl == "LH") | (Pl == "MA"))
            {
                c1 = 32.7621;
                c2 = 1.1;
                c3 = 9.9241;
            }
            if ((Pl == "NU") | (Pl == "TS") | (Pl == "KU") | (Pl == "TO"))
            {
                c1 = 37.2351;
                c2 = 1.3;
                c3 = 10.858;
            }

            return 1.3 + c1 * Math.Pow(D / (D + c2), c3);
        }

        static double KooreProtsent(string Pl, double p_d)
        {
            double c1 = 12.0;
            double c2 = 2;
            double c3 = -3.2;

            if ((Pl == "KS") | (Pl == "PN"))
            {
                c1 = 11.1;
                c2 = 3;
                c3 = -4.9;
            }

            if ((Pl == "KU") | (Pl == "LH") | (Pl == "NU") | (Pl == "TS"))
            {
                c1 = 8.0;
                c2 = 2;
                c3 = -4.9;
            }

            if ((Pl == "MA") | (Pl == "SD") | (Pl == "TO"))
            {
                c1 = 6.0;
                c2 = 10;
                c3 = -17.5;
            }

            if ((Pl == "LM") | (Pl == "LV") | (Pl == "RE"))
            {
                c1 = 10.8;
                c2 = 2;
                c3 = -4.0;
            }
            return c1 * Math.Pow((p_d + c2) / (p_d + c2 + 1), c3) / 100;
        }

        static double ozol_D(string Pl, double p_d, double p_h, double x_h)
        {

            double c1 = 752.018; double c10 = 0.0002; double c11 = 20; double c2 = -2212.940;
            double c3 = 2606.605; double c4 = -1643.304; double c5 = 530.481; double c6 = -143.288;
            double c7 = 110.428; double c8 = 0.0074; double c9 = 18;

            if ((Pl == "KP") | (Pl == "JA") | (Pl == "VA") | (Pl == "TA"))
            {
                c1 = 2971.333; c2 = -9254.632; c3 = 11231.250;
                c4 = -6736.346; c5 = 2022.206; c6 = -354.769; c7 = 120.958;
                c8 = 0.0263; c9 = 14; c10 = 0.0005; c11 = 20;
            }

            if (Pl == "SA")
            {
                c1 = 2506.62; c2 = -7175.007; c3 = 7964.660;
                c4 = -4542.395; c5 = 1411.064; c6 = -282.941; c7 = 117.999;
                c8 = 0.0000; c9 = 20; c10 = -0.0021; c11 = 21;
            }

            if (Pl == "LV")
            {
                c1 = 626.131;
                c10 = -0.0103;
                c11 = 16;
                c2 = -2137.684;
                c3 = 3045.214;
                c4 = -2376.874;
                c5 = 988.135;
                c6 = -263.482;
                c7 = 118.560;
                c8 = 0.0168;
                c9 = 16;
            }

            if (Pl == "LM")
            {
                c1 = 1743.640;
                c10 = -0.0017;
                c11 = 12;
                c2 = -5408.312;
                c3 = 6644.011;
                c4 = -4238.703;
                c5 = 1450.125;
                c6 = -310.985;
                c7 = 120.224;
                c8 = 0.0264;
                c9 = 14;
            }

            if (Pl == "KS")
            {
                c1 = 1120.891;
                c10 = 0.0000;
                c11 = 28;
                c2 = -3788.858;
                c3 = 5197.005;
                c4 = -3725.819;
                c5 = 1388.288;
                c6 = -312.074;
                c7 = 120.567;
                c8 = 0.0210;
                c9 = 20;
            }

            if ((Pl == "NU") | (Pl == "TS") | (Pl == "KU"))
            {
                c1 = 390.755; c2 = -1699.667; c3 = 2732.076;
                c4 = -2161.251; c5 = 827.209; c6 = -203.061; c7 = 113.939;
                c8 = 0.0087; c9 = 33; c10 = -0.0097; c11 = 36;
            }

            if ((Pl == "TO") | (Pl == "SD") | (Pl == "LH") | (Pl == "MA"))
            {
                c1 = 997.657;
                c10 = -0.0070;
                c11 = 30;
                c2 = -3361.780;
                c3 = 4419.682;
                c4 = -3037.487;
                c5 = 1140.525;
                c6 = -277.578;
                c7 = 118.981;
                c8 = 0.0070;
                c9 = 26;
            }
            double ipf1 = x_h / p_h;
            double ipf2 = 1.3 / p_h;
            return p_d * ((((((c1 * ipf1 + c2) * ipf1 + c3) * ipf1 + c4) * ipf1 + c5) * ipf1 + c6) * ipf1 + c7) * (1 + (ipf1 * ipf1 - 0.01) * (c8 * (p_h - c9) + c10 * (p_d - c11))) /
                (((((((c1 * ipf2 + c2) * ipf2 + c3) * ipf2 + c4) * ipf2 + c5) * ipf2 + c6) * ipf2 + c7) * (1 + (ipf2 * ipf2 - 0.01) * (c8 * (p_h - c9) + c10 * (p_d - c11))));
        }

    }
}
