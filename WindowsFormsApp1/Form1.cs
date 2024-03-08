using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int rim1 = 0;
        public int rim2 = 0;
        public int rimrez;
        public int mrimrez;
        public char[] r = { 'I', 'V', 'X', 'L', 'C', 'D', 'M', '█' };
        public int[] ri = { 1, 5, 10, 50, 100, 500, 1000, 2 };

        public static bool ProveriRimski(string rimski)
        {
            string strRegex = @"^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(rimski))
                return true;
            else
                return false;
        }

        public static string ArapskiURimski(int broj)
        {
            if (broj > 3999)
            {
                MessageBox.Show("Ne moze");
                return "";
            }


            int pom = broj;
            int jedinice = broj % 10;
            int desetice = broj % 100 - jedinice;
            int stotine = broj % 1000 - jedinice - desetice;
            string AuRrez = "";

            while (pom > 0)
            {
                if (pom >= 1000)
                {
                    pom -= 1000;
                    AuRrez += "M";
                    continue;
                }

                else if (stotine == 900)
                {
                    stotine -= 900;
                    pom -= 900;
                    AuRrez += "CM";
                    continue;
                }

                else if (stotine >= 500)
                {
                    stotine -= 500;
                    pom -= 500;
                    AuRrez += "D";
                    continue;
                }

                else if (stotine == 400)
                {
                    stotine -= 400;
                    pom -= 400;
                    AuRrez += "CD";
                    continue;
                }

                else if (stotine >= 100)
                {
                    stotine -= 100;
                    pom -= 100;
                    AuRrez += "C";
                    continue;
                }

                else if (desetice == 90)
                {
                    desetice -= 90;
                    pom -= 90;
                    AuRrez += "XC";
                    continue;
                }

                else if (desetice >= 50)
                {
                    desetice -= 50;
                    pom -= 50;
                    AuRrez += "L";
                    continue;
                }

                else if (desetice == 40)
                {
                    desetice -= 40;
                    pom -= 40;
                    AuRrez += "XL";
                    continue;
                }

                else if (desetice >= 10)
                {
                    desetice -= 10;
                    pom -= 10;
                    AuRrez += "X";
                    continue;
                }

                else if (jedinice == 9)
                {
                    jedinice -= 9;
                    pom -= 9;
                    AuRrez += "IX";
                    continue;
                }

                else if (jedinice >= 5)
                {
                    jedinice -= 5;
                    pom -= 5;
                    AuRrez += "V";
                    continue;
                }

                else if (jedinice == 4)
                {
                    jedinice -= 4;
                    pom -= 4;
                    AuRrez += "IV";
                    continue;
                }

                else if (jedinice >= 1)
                {
                    jedinice -= 1;
                    pom -= 1;
                    AuRrez += "I";
                    continue;
                }
            }
            return AuRrez;

        }



        private void btSabiranje_Click(object sender, EventArgs e)
        {
            List<char> res = new List<char>();
            string b1 = txtBroj1.Text;
            string b2 = txtBroj2.Text;
            int prenosi = 0;
            int p;
            int t1 = 0;
            int t2 = 0;
            int p1 = 0;
            int p2 = 0;

            if (txtBroj1.Text[0] == '-' && txtBroj2.Text[0] == '-')
            {
                txtBroj1.Text = txtBroj1.Text.Remove(0, 1);
                txtBroj2.Text = txtBroj2.Text.Remove(0, 1);

                btSabiranje.PerformClick();
                txtBroj1.Text = "-" + txtBroj1.Text;
                txtBroj2.Text = "-" + txtBroj2.Text;
                lblResenje.Text = "-" + lblResenje.Text;
            }

            else if (txtBroj1.Text[0] == '-')
            {
                txtBroj1.Text = txtBroj1.Text.Remove(0, 1);
                string pom;
                pom = txtBroj1.Text;
                txtBroj1.Text = txtBroj2.Text;
                txtBroj2.Text = pom;
                btOduzimanje.PerformClick();
                pom = txtBroj1.Text;
                txtBroj1.Text = txtBroj2.Text;
                txtBroj2.Text = pom;
                txtBroj1.Text = "-" + txtBroj1.Text;
            }
            else if (txtBroj2.Text[0] == '-')
            {
                txtBroj2.Text = txtBroj2.Text.Remove(0, 1);
                btOduzimanje.PerformClick();
                txtBroj2.Text = "-" + txtBroj2.Text;
            }
            else
            {



                if (!b1.Contains("."))
                {
                    b1 = b1 + ".0";
                }
                if (!b2.Contains("."))
                {
                    b2 = b2 + ".0";
                }

                for (int i = b1.Length - 1; i >= 0; i--)
                {
                    if (b1[i].Equals('.')) break;
                    else t1++;
                }

                for (int i = b2.Length - 1; i >= 0; i--)
                {
                    if (b2[i] == '.') break;
                    else t2++;
                }

                if (t1 > t2)
                {
                    for (int i = 0; i < (t1 - t2); i++)
                    {
                        b2 = b2 + '0';
                    }
                }

                if (t2 > t1)
                {
                    for (int i = 0; i < (t2 - t1); i++)
                    {
                        b1 = b1 + '0';
                    }
                }

                for (int i = 0; i < b1.Length; i++)
                {
                    if (b1[i] == '.') break;
                    else p1++;
                }

                for (int i = 0; i < b2.Length; i++)
                {
                    if (b2[i] == '.') break;
                    else p2++;
                }

                if (p1 > p2)
                {
                    for (int i = 0; i < (p1 - p2); i++)
                    {
                        b2 = '0' + b2;
                    }
                }

                if (p2 > p1)
                {
                    for (int i = 0; i < (p2 - p1); i++)
                    {
                        b1 = '0' + b1;
                    }
                }

                for (int i = 0; i < b1.Length; i++)
                {
                    if (b1[i] != '.') res.Add('0');
                    else res.Add('.');
                }

                for (int i = b1.Length - 1; i >= 0; i--)
                {
                    if (b1[i] == ('.'))
                    {
                        continue;
                    }

                    int broj1 = int.Parse(b1[i].ToString());
                    int broj2 = int.Parse(b2[i].ToString());
                    int brojres = int.Parse(res[i].ToString());

                    if ((broj1 + broj2 + brojres) < 10)
                    {
                        res[i] = Convert.ToChar(broj1 + broj2 + brojres + 48);
                    }
                    else
                    {

                        if (i > 0)
                        {
                            if (res[i - 1] == '.')
                            {
                                res[i - 2] = Convert.ToChar(Convert.ToInt32(res[i - 2]) + 1);
                            }
                            else
                            {
                                res[i - 1] = Convert.ToChar(Convert.ToInt32(res[i - 1]) + 1);

                            }

                        }

                        if (i == 0)
                        {
                            prenosi = 1;
                            continue;
                        }
                        res[i] = Convert.ToChar((broj1 + broj2 + brojres) % 10 + 48);
                    }

                }

                if (prenosi == 1)
                {
                    lblResenje.Text = "1";
                }
                else
                {
                    lblResenje.Text = "";
                }


                for (int i = res.Count - 1; i >= 0; i--)
                {
                    if (res[i] == '0') res.RemoveAt(i);
                    else
                    {
                        if (res[i] == '.') res.RemoveAt(i);
                        break;
                    }

                }


                for (int i = 0; i < res.Count; i++)
                {
                    lblResenje.Text = lblResenje.Text + res[i];
                }
            }

        }

        private void btOduzimanje_Click(object sender, EventArgs e)
        {
            List<char> res = new List<char>();
            List<char> b1 = new List<char>();
            List<char> b2 = new List<char>();
            bool b1imatacku = false;
            bool b2imatacku = false;

            lblResenje.Text = "";
            if (txtBroj1.Text[0] == '-' && txtBroj2.Text[0] == '-')
            {
                txtBroj1.Text = txtBroj1.Text.Remove(0, 1);
                txtBroj2.Text = txtBroj2.Text.Remove(0, 1);
                string pom;
                pom = txtBroj1.Text;
                txtBroj1.Text = txtBroj2.Text;
                txtBroj2.Text = pom;
                btOduzimanje.PerformClick();
                pom = txtBroj1.Text;
                txtBroj1.Text = txtBroj2.Text;
                txtBroj2.Text = pom;
                txtBroj1.Text = "-" + txtBroj1.Text;
                txtBroj2.Text = "-" + txtBroj2.Text;
            }
            else if (txtBroj1.Text[0] == '-')
            {
                txtBroj1.Text = txtBroj1.Text.Remove(0, 1);
                btSabiranje.PerformClick();
                txtBroj1.Text = "-" + txtBroj1.Text;
                lblResenje.Text = "-" + lblResenje.Text;
            }
            else if (txtBroj2.Text[0] == '-')
            {
                txtBroj2.Text = txtBroj2.Text.Remove(0, 1);
                btSabiranje.PerformClick();
                txtBroj2.Text = "-" + txtBroj2.Text;
            }
            else
            {
                string da = lblResenje.Text;

                for (int i = 0; i < txtBroj1.Text.Length; i++)
                {
                    b1.Add(txtBroj1.Text[i]);
                }
                for (int i = 0; i < txtBroj2.Text.Length; i++)
                {
                    b2.Add(txtBroj2.Text[i]);
                }

                for (int i = 0; i < b1.Count; i++)
                {
                    if (b1[i] == '.') b1imatacku = true;

                }

                for (int i = 0; i < b2.Count; i++)
                {
                    if (b2[i] == '.') b2imatacku = true;
                }

                if (b1imatacku == false)
                {
                    b1.Add('.');
                    b1.Add('0');
                }

                if (b2imatacku == false)
                {
                    b2.Add('.');
                    b2.Add('0');
                }



                int p;
                int t1 = 0;
                int t2 = 0;
                int p1 = 0;
                int p2 = 0;
                bool dodajminus = false;

                for (int i = b1.Count - 1; i >= 0; i--)
                {
                    if (b1[i].Equals('.')) break;
                    else t1++;
                }

                for (int i = b2.Count - 1; i >= 0; i--)
                {
                    if (b2[i] == '.') break;
                    else t2++;
                }

                if (t1 > t2)
                {
                    for (int i = 0; i < (t1 - t2); i++)
                    {
                        b2.Add('0');
                    }
                }

                if (t2 > t1)
                {
                    for (int i = 0; i < (t2 - t1); i++)
                    {
                        b1.Add('0');
                    }
                }

                for (int i = 0; i < b1.Count; i++)
                {
                    if (b1[i] == '.') break;
                    else p1++;
                }

                for (int i = 0; i < b2.Count; i++)
                {
                    if (b2[i] == '.') break;
                    else p2++;
                }

                if (p1 > p2)
                {
                    for (int i = 0; i < (p1 - p2); i++)
                    {
                        b2.Reverse();
                        b2.Add('0');
                        b2.Reverse();
                    }
                }

                if (p2 > p1)
                {
                    for (int i = 0; i < (p2 - p1); i++)
                    {
                        b1.Reverse();
                        b1.Add('0');
                        b1.Reverse();

                    }
                }

                for (int i = 0; i < b1.Count; i++)
                {
                    if (b1[i] != '.') res.Add('0');
                    else res.Add('.');
                }





                lblResenje.Text = "";


                List<char> pb1 = new List<char>();
                List<char> pb2 = new List<char>();
                string s = "";

                if (p1 > p2)
                {
                    for (int i = 0; i < b1.Count; i++)
                    {
                        pb1.Add(b1[i]);
                    }
                    for (int i = 0; i < b2.Count; i++)
                    {
                        pb2.Add(b2[i]);
                    }
                }
                else if (p2 > p1)
                {
                    for (int i = 0; i < b1.Count; i++)
                    {
                        pb1.Add(b2[i]);
                    }
                    for (int i = 0; i < b2.Count; i++)
                    {
                        pb2.Add(b1[i]);
                    }
                    lblResenje.Text = "-" + lblResenje.Text;
                }
                else if (b1.Count == b2.Count)
                {
                    for (int i = 0; i < res.Count; i++)
                    {
                        if (res[i] == ('.'))
                        {
                            continue;
                        }

                        if (b1[i] > b2[i])
                        {
                            for (int j = 0; j < b1.Count; j++)
                            {
                                pb1.Add(b1[j]);
                            }
                            for (int j = 0; j < b2.Count; j++)
                            {
                                pb2.Add(b2[j]);
                            }
                            break;
                        }


                        else if (b2[i] > b1[i])
                        {
                            for (int j = 0; j < b2.Count; j++)
                            {
                                pb1.Add(b2[j]);
                            }
                            for (int j = 0; j < b1.Count; j++)
                            {
                                pb2.Add(b1[j]);
                            }
                            dodajminus = true;
                            break;
                        }
                        else
                        {
                            for (int j = 0; j < b2.Count; j++)
                            {
                                pb1.Add(b2[j]);
                                pb2.Add(b2[j]);
                            }
                        }

                    }

                }




                
                for (int i = b1.Count - 1; i >= 0; i--)
                {
                    if (b1[i] == ('.'))
                    {
                        continue;
                    }

                    int broj1 = int.Parse(pb1[i].ToString());
                    int broj2 = int.Parse(pb2[i].ToString());
                    int brojres = int.Parse(res[i].ToString());


                    if (broj1 >= broj2)
                    {
                        res[i] = Convert.ToChar(broj1 - broj2 + 48);

                    }
                    else
                    {
                        broj1 += 10;
                        if (pb1[i - 1] == '.')
                        {
                            pb1[i - 2] = Convert.ToChar((Convert.ToInt16(pb1[i-2])-48)+48);
                        }
                        else
                        {
                            pb1[i - 1] = Convert.ToChar((Convert.ToInt16(pb1[i - 1]) - 48) + 48);
                        }

                        res[i] = Convert.ToChar(broj1 - broj2 + 48);

                    }




                }





                    for (int i = 0; i < res.Count; i++)
                    {
                        if (res[i] == '0') res.RemoveAt(i);
                        else break;
                    }

                    for (int i = res.Count - 1; i >= 0; i--)
                    {
                        if (res[i] == '0') res.RemoveAt(i);
                        else
                        {
                            if (res[i] == '.') res.RemoveAt(i);
                            break;
                        }

                    }


                    if (dodajminus)
                    {
                        res.Reverse();
                        res.Add('-');
                        res.Reverse();

                    }

                    
                    for (int i = 0; i < res.Count; i++)
                    {
                        lblResenje.Text = lblResenje.Text + res[i];
                    }




                
            }

        }


        public int kojijeveci(List<char> A, List<char> B)
        {
            if (A.Count > B.Count) return 1;
            if (B.Count > A.Count) return -1;
            if (A.Count == B.Count)
            {
                for (int i = 0; i < A.Count; i++)
                {
                    if (A[i] > B[i]) return 1;
                    if (B[i] > A[i]) return -1;
                }
            }
            return 0;
        }



        public List<char> sabiranje(List<char> prva, List<char> druga)
        {
            List<char> res = new List<char>();
            List<char> resenje = new List<char>();
            List<char> A = new List<char>();
            List<char> B = new List<char>();

            for (int i = 0; i < prva.Count; i++)
            {
                A.Add(prva[i]);
            }

            for (int i = 0; i < druga.Count; i++)
            {
                B.Add(druga[i]);
            }


            int prenosi = 0;

            int Acifara = 0;
            int Bcifara = 0;

            for (int i = 0; i < A.Count; i++)
            {
                Acifara++;
            }

            for (int i = 0; i < B.Count; i++)
            {
                Bcifara++;
            }


            if (Acifara > Bcifara)
            {
                B.Reverse();
                while (Acifara != Bcifara)
                {
                    B.Add('0');
                    Bcifara++;
                }
                B.Reverse();
            }

            if (Bcifara > Acifara)
            {
                A.Reverse();
                while (Acifara != Bcifara)
                {
                    A.Add('0');
                    Acifara++;
                }
                A.Reverse();
            }

            for (int i = A.Count - 1; i >= 0; i--)
            {
                if ((Convert.ToInt16(A[i] + prenosi - 48) + Convert.ToInt16(B[i] - 48)) < 10)
                {
                    string a = Convert.ToString(Convert.ToInt16(A[i] + prenosi - 48));
                    string b = Convert.ToString(Convert.ToInt16(B[i] - 48));

                    int aBroj = int.Parse(a);
                    int bBroj = int.Parse(b);

                    int broj = aBroj + bBroj;

                    res.Add(Convert.ToChar(broj + 48));
                    prenosi = 0;
                }
                else
                {
                    int gugugaga = ((Convert.ToInt16(A[i] + prenosi - 48) + Convert.ToInt16(B[i] - 48)) % 10);
                    res.Add(Convert.ToChar(gugugaga + 48));
                    prenosi = 1;
                }
            }

            if (prenosi == 1)
            {
                //res.Reverse();
                res.Add('1');
                //res.Reverse();
            }
            res.Reverse();
            return res;
        }


        public List<char> oduzimanje(List<char> prva, List<char> druga)
        {
            List<char> res = new List<char>();
            List<char> A = new List<char>();
            List<char> B = new List<char>();
            int c = 0;


            for (int i = 0; i < prva.Count; i++)
            {
                A.Add(prva[i]);
            }

            for (int i = 0; i < druga.Count; i++)
            {
                B.Add(druga[i]);
            }


            if (A.Count > B.Count)
            {
                B.Reverse();
                while (A.Count != B.Count)
                {
                    B.Add('0');
                }
                B.Reverse();
            }



            if (B.Count > A.Count)
            {
                A.Reverse();
                while (A.Count != B.Count)
                {
                    A.Add('0');
                }
                A.Reverse();
            }



            for (int i = 0; i < A.Count; i++)
            {
                res.Add('0');
            }
            
            for (int i = A.Count - 1; i >= 0; i--)
            {
                    
                int broj1 = c + int.Parse(Convert.ToString(Convert.ToInt16(A[i] - 48)));
                int broj2 = int.Parse(Convert.ToString(Convert.ToInt16(B[i] - 48)));
                int brojres = int.Parse(Convert.ToString(Convert.ToInt16(res[i] - 48)));
                c = 0;

                if (broj1 >= broj2)
                {
                    res[i] = Convert.ToChar(broj1 - broj2 + 48);

                }
                else
                {
                    broj1 += 10;
                    c = -1;
                    res[i] = Convert.ToChar(broj1 - broj2 + 48);

                }

            }

            while (res[0] == '0')
            {
                res.RemoveAt(0);
                if (res.Count == 0) break;
            }

            return res;

        }


        private void btDeljenje_Click(object sender, EventArgs e)
        {
            bool deljenikNula = false;
            bool delilacNula = false;
            lblResenje.Text = "";
            string res;
            List<char> b1 = new List<char>();
            List<char> b2 = new List<char>();
            List<char> b3 = new List<char>();
            List<char> b4 = new List<char>();
            List<char> sacuvajb3 = new List<char>();
            List<char> sacuvajb4 = new List<char>();
            List<char> drugisacuvajb4 = new List<char>();
            int b1PosleZareza = 0;
            int b2PosleZareza = 0;

            int b1nule;
            int b2nule;
            int t = 0;
            int prolazak = 0;
            int resenje = 0;

            bool b1minus = false;
            bool b2minus = false;

            bool b1dodajminusposle = false;
            bool b2dodajminusposle = false;


            if (txtBroj1.Text[0] == '-' && txtBroj2.Text[0] == '-')
            {
                b1minus = true;
                b2minus = true;
                txtBroj1.Text = txtBroj1.Text.Remove(0, 1);
                txtBroj2.Text = txtBroj2.Text.Remove(0, 1);
            }
            else if (txtBroj1.Text[0] == '-')
            {
                b1dodajminusposle = true;
                b1minus = true;
                txtBroj1.Text = txtBroj1.Text.Remove(0, 1);
            }
            else if (txtBroj2.Text[0] == '-')
            {
                b2dodajminusposle = true;
                b2minus = true;
                txtBroj2.Text = txtBroj2.Text.Remove(0, 1);
            }

            for (int i = 0; i < txtBroj1.Text.Length; i++)
            {
                b1.Add(txtBroj1.Text[i]);
            }
            for (int i = 0; i < txtBroj2.Text.Length; i++)
            {
                b2.Add(txtBroj2.Text[i]);
            }


            if (b1minus)
            {
                txtBroj1.Text = "-" + txtBroj1.Text;
                b1minus = false;
            }
            if (b2minus)
            {
                txtBroj2.Text = "-" + txtBroj2.Text;
                b2minus = false;
            }




            deljenikNula = true;
            for (int i = 0; i < b1.Count; i++)
            {
                if (b1[i] == '.') continue;
                if (b1[i] != '0')
                {
                    deljenikNula = false;
                    break;
                }    
            }

            delilacNula = true;
            for (int i = 0; i < b2.Count; i++)
            {
                if (b2[i] == '.') continue;
                if (b2[i] != '0')
                {
                    delilacNula = false;
                    break;
                }
            }




            for (int i = (b1.Count)-1; i >= 0; i--)
            {
                if (b1[i] == '.')
                {
                    b1.RemoveAt(i);
                    b1PosleZareza = b1.Count - i;
                    break;
                }
            }

            for (int i = b2.Count - 1; i >= 0; i--)
            {
                if (b2[i] == '.')
                {
                    b2.RemoveAt(i);
                    b2PosleZareza = b2.Count - i;
                    break;
                }
            }




            if (b1PosleZareza > b2PosleZareza)
            {
                for (int i = 0; i < b1PosleZareza-b2PosleZareza; i++)
                {
                    b2.Add('0');
                }
            }

            if (b2PosleZareza > b1PosleZareza)
            {
                for (int i = 0; i < b2PosleZareza - b1PosleZareza; i++)
                {
                    b1.Add('0');
                }
            }


            for (int i = 0; i < b1.Count; i++)
            {
                if (b1[i] == '.')
                {
                    b1nule = b1.Count - i;
                    b1.RemoveAt(i);
                    break;
                }
            }


            for (int i = 0; i < b2.Count; i++)
            {
                if (b2[i] == '.')
                {
                    b2nule = b2.Count - i;
                    b2.RemoveAt(i);
                    break;
                }
            }








            while (b1[0] == '0')
            {
                b1.RemoveAt(0);
                if (b1.Count == 0) break;
            }

            while (b2[0] == '0')
            {
                b2.RemoveAt(0);
                if (b2.Count == 0) break;
            }


            if (kojijeveci(b1, b2) < 0)
            {
                lblResenje.Text = "0" + lblResenje.Text;
            }


            if (b1dodajminusposle || b2dodajminusposle)
            {
                lblResenje.Text = "-" + lblResenje.Text;
            }


            t = 0;
            bool zarez = false;
            while (lblResenje.Text.Length < 10)
            {
                if (deljenikNula == true)
                {
                    lblResenje.Text = "0";
                    break;
                }

                if (delilacNula == true)
                {
                    lblResenje.Text = "Ne moze!";
                    MessageBox.Show("Ne moze!");
                    break;
                }



                
                resenje = 0;
                b4.Clear();

                for (int i = 0; i < b2.Count; i++)
                {
                    b4.Add(b2[i]);
                } 


                while (kojijeveci(b3,b4) < 0)
                {
                    if (t >= b1.Count)
                    {
                        if (!zarez)
                        {
                            lblResenje.Text = lblResenje.Text + ".";
                            res = lblResenje.Text;
                            zarez = true;
                        }

                        
                        b3.Add('0');
                        zarez = true;
                        t++;
                        break;
                        
                    }
                    else
                    {
                        b3.Add(b1[t]);
                        t++;
                    }
                }


                //if(kojijeveci(b4,b2) < 0)
                {
                    //lblResenje.Text = lblResenje.Text + "0";
                    //res = lblResenje.Text;
                    //continue;
                }


                //sacuvajb4.Reverse();
                //drugisacuvajb4.Reverse();
                sacuvajb4.Clear();
                drugisacuvajb4.Clear();
                for (int i = 0; i < b4.Count; i++)
                {
                    sacuvajb4.Add(b4[i]);
                }
                for (int i = 0; i < b4.Count; i++)
                {
                    drugisacuvajb4.Add(b4[i]);
                }
                //sacuvajb4.Reverse();
                //drugisacuvajb4.Reverse();

                while (kojijeveci(b3,b4) > 0)
                {
                    resenje++;

                    b4.Clear();
                    for (int i = 0; i < sabiranje(drugisacuvajb4, sacuvajb4).Count; i++)
                    {
                        b4.Add(sabiranje(drugisacuvajb4, sacuvajb4)[i]);
                    }

                    sacuvajb4.Clear();
                    for (int i = 0; i < b4.Count; i++)
                    {
                        sacuvajb4.Add(b4[i]);
                    }
                }


                if (kojijeveci(b3,b4) == 0)
                {
                    lblResenje.Text = lblResenje.Text + (resenje + 1);
                    break;
                }

                lblResenje.Text = lblResenje.Text + resenje;
                res = lblResenje.Text;



                sacuvajb4.Clear();
                for (int i = 0; i < b4.Count; i++)
                {
                    sacuvajb4.Add(b4[i]);
                }

                b4.Clear();
                for (int i = 0; i < oduzimanje(sacuvajb4,drugisacuvajb4).Count; i++)
                {
                    b4.Add(oduzimanje(sacuvajb4, drugisacuvajb4)[i]);

                }

                sacuvajb3.Clear();
                for (int i = 0; i < b3.Count; i++)
                {
                    sacuvajb3.Add(b3[i]);
                }

                b3.Clear();
                for (int i = 0; i < oduzimanje(sacuvajb3,b4).Count; i++)
                {
                    b3.Add(oduzimanje(sacuvajb3, b4)[i]);

                }
            }
        }











        private List<int> mnoziJednuCifru(List<int> b1, int jednaCifra, List<int> res, int t)
        {
            int prenesi = 0;

            List<int> broj1 = new List<int>();
            List<int> resenje = new List<int>();
            List<char> chResenje = new List<char>();
            List<char> chRes = new List<char>();
            int cifra = jednaCifra;

            for (int i = 0; i < b1.Count; i++)
            {
                broj1.Add(b1[i]);
            }


            for (int i = broj1.Count-1; i >= 0; i--)
            {
                if ((broj1[i] * cifra) + prenesi < 10)
                {
                    resenje.Add((broj1[i] * cifra) + prenesi);
                    prenesi = 0;

                }
                else
                {
                    resenje.Add(((broj1[i] * cifra) + prenesi) % 10);
                    prenesi = ((broj1[i] * cifra) + prenesi) / 10;
                }


            }

            if (prenesi != 0) resenje.Add(prenesi);
            resenje.Reverse();
            for (int i = 0; i < t; i++)
            {
                resenje.Add(0);
            }

            chResenje.Clear();
            for (int i = 0; i < resenje.Count; i++)
            {
                chResenje.Add(Convert.ToChar(resenje[i] + 48));
            }

            chRes.Clear();
            for (int i = 0; i < res.Count; i++)
            {
                chRes.Add(Convert.ToChar(res[i] + 48));
            }


            List<char> sacuvajRes = new List<char>();

            for (int i = 0; i < chRes.Count; i++)
            {
                sacuvajRes.Add(chRes[i]);
            }

            chRes.Clear();
            for (int i = 0; i < sabiranje(chResenje,sacuvajRes).Count; i++)
            {
                chRes.Add(sabiranje(chResenje, sacuvajRes)[i]);
            }


            res.Clear();
            for (int i = 0; i < chRes.Count; i++)
            {
                res.Add(Convert.ToInt16(chRes[i] - 48));
            }


            return res;
        }




        private void btMnozenje_Click(object sender, EventArgs e)
        {
            int t = 0;
            List<int> b1 = new List<int>();
            List<int> b2 = new List<int>();
            List<int> res = new List<int>();

            bool b1Nula = false;
            bool b2Nula = false;

            int b1PosleZareza = 0;
            int b2PosleZareza = 0;

            bool b1zarez = false;
            bool b2zarez = false;

            bool b1minus = false;
            bool b2minus = false;

            lblResenje.Text = "";
            if (txtBroj1.Text[0] == '-' && txtBroj2.Text[0] == '-')
            {
                b1minus = true;
                b2minus = true;
                txtBroj1.Text = txtBroj1.Text.Remove(0, 1);
                txtBroj2.Text = txtBroj2.Text.Remove(0, 1);
            }
            else if (txtBroj1.Text[0] == '-')
            {
                b1minus = true;
                lblResenje.Text = lblResenje.Text + "-";
                txtBroj1.Text = txtBroj1.Text.Remove(0, 1);
            }
            else if (txtBroj2.Text[0] == '-')
            {
                b2minus = true;
                lblResenje.Text = lblResenje.Text + "-";
                txtBroj2.Text = txtBroj2.Text.Remove(0, 1);
            }

            for (int i = 0; i < txtBroj1.Text.Length; i++)
            {
                if (b1zarez) b1PosleZareza++;
                if (txtBroj1.Text[i] == '.')
                {
                    b1zarez = true;
                    continue;
                }
                b1.Add(txtBroj1.Text[i] - 48);

            }
            for (int i = 0; i < txtBroj2.Text.Length; i++)
            {
                if (b2zarez) b2PosleZareza++;
                if (txtBroj2.Text[i] == '.')
                {
                    b2zarez = true;
                    continue;
                }
                b2.Add(txtBroj2.Text[i] - 48);
            }


            if (b1minus)
            {
                txtBroj1.Text = "-" + txtBroj1.Text;
                b1minus = false;
            }
            if (b2minus)
            {
                txtBroj2.Text = "-" + txtBroj2.Text;
                b2minus = false;
            }



            for (int i = 0; i < b2.Count; i++)
            {
                res.Add(0);
            }




            b1Nula = true;
            for (int i = 0; i < b1.Count; i++)
            {
                if (b1[i] != 0)
                {
                    b1Nula = false;
                    break;
                }
            }

            b2Nula = true;
            for (int i = 0; i < b2.Count; i++)
            {
                if (b2[i] != 0)
                {
                    b2Nula = false;
                    break;
                }
            }

            for (int i = b2.Count-1; i >= 0; i--)
            {
                if (b1Nula || b2Nula)
                {
                    lblResenje.Text = "0";
                    break;
                }
                mnoziJednuCifru(b1, b2[i], res, t);
                t++;

                

            }









            if (lblResenje.Text == "" || lblResenje.Text[0] == '-')
            {
                for (int j = 0; j < res.Count; j++)
                {


                    if (j > 10) break;
                    if (j == res.Count - b1PosleZareza - b2PosleZareza) lblResenje.Text = lblResenje.Text + ".";
                    lblResenje.Text = lblResenje.Text + Convert.ToString(res[j]);
                }
            }
            

        }

        private void txtRimski1_TextChanged(object sender, EventArgs e)
        {
            if (ProveriRimski(txtRimski1.Text))
            {
                rim1 = 0;
                string s = txtRimski1.Text;
                for (int i = 0; i < s.Length - 1; i++)
                {
                    for (int j = 0; j < r.Length; j++)
                    {
                        if (r[j] == s[i])
                        {
                            for (int k = 0; k < r.Length; k++)
                            {
                                if (r[k] == s[i + 1])
                                {
                                    if (ri[j] >= ri[k])
                                    {
                                        rim1 += Convert.ToInt32(ri[j]);
                                    }
                                    else
                                    {
                                        rim1 -= Convert.ToInt32(ri[j]);
                                    }
                                }

                            }
                        }

                    }

                }

                if (s.Length > 0)
                {
                    for (int i = 0; i < r.Length; i++)
                    {

                        if (r[i] == s.Last())
                        {
                            rim1 += ri[i];

                        }

                    }
                }

            }
            else
            {
                MessageBox.Show("Ne moze");
                txtRimski1.Text = txtRimski1.Text.Remove(txtRimski1.Text.Length - 1, 1);
            }
        }

        private void txtRimski2_TextChanged(object sender, EventArgs e)
        {
            if (ProveriRimski(txtRimski2.Text))
            {
                rim2 = 0;
                string s = txtRimski2.Text;
                for (int i = 0; i < s.Length - 1; i++)
                {
                    for (int j = 0; j < r.Length; j++)
                    {
                        if (r[j] == s[i])
                        {

                            for (int k = 0; k < r.Length; k++)
                            {
                                if (r[k] == s[i + 1])
                                {
                                    if (ri[j] >= ri[k])
                                    {
                                        rim2 += Convert.ToInt32(ri[j]);
                                    }
                                    else
                                    {
                                        rim2 -= Convert.ToInt32(ri[j]);
                                    }
                                }

                            }



                        }

                    }

                }

                if (s.Length > 0)
                {
                    for (int i = 0; i < r.Length; i++)
                    {
                        if (r[i] == s.Last())
                        {
                            rim2 += ri[i];

                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Ne moze");
                txtRimski2.Text = txtRimski2.Text.Remove(txtRimski2.Text.Length - 1, 1);
            }
        }

        private void brPlus_Click(object sender, EventArgs e)
        {
            rimrez = rim1 + rim2;
            lblRimski.Text = ArapskiURimski(rimrez);
        }

        private void brMinus_Click(object sender, EventArgs e)
        {
            if ((rim1 - rim2) < 0) MessageBox.Show("Ne moze");
            {
                rimrez = rim1 - rim2;
                lblRimski.Text = ArapskiURimski(rimrez);
            }
        }

        private void brDeljenje_Click(object sender, EventArgs e)
        {
            lblRimski.Text = "";
            rimrez = rim1 / rim2;
            mrimrez = rim1 % rim2;
            lblRimski.Text += ArapskiURimski(rimrez);
            lblRimski.Text += " ostatak: " + ArapskiURimski(mrimrez);
        }

        private void brPuta_Click(object sender, EventArgs e)
        {
            rimrez = rim1 * rim2;
            lblRimski.Text = ArapskiURimski(rimrez);
        }

        private void lblRimski_Click(object sender, EventArgs e)
        {

        }
    }
}
