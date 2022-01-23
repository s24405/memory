using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Form1 : Form
    {
        bool[] czy_przyciski_maja_kolor = new bool[17];  // bool bo moze byc tylko prawda lub falsz
        Color[] kolory = new Color[17]; // mamy 16 buttonow plus jeden dodatkowy o wartosci 0 zeby przycisk 1 to byl 1 a nie 0 
        bool[] zakryte = new bool[17]; //potrzebujemy tego do sprawdzenia czy przycisk posiada juz kolor// bool bo true or false zakryty lub nie 
        bool czy_pierwszy_klik = true; //jesli tak to po kliknieciu na odwrocony juz przycisk nic sie nei stanie nowewgo
        int ruchy = 0; //ilosc wykonanych ruchow, przy utuchomieniu jest zero
        int numer_pierwszego = 0; //color new color{[17] to nasza tablica w ktr jest info jaki kolor gdzied jest 
        int numer_drugiego = 0; //1 klikniecie, numer oprzycisku zapisywany w n1, 2 klikniecie apisywane w n2 aby program pamietal jakie przyciski byly wybrane

        public Form1()
        {
            InitializeComponent(); //automatyczna metoda podczas tworzenia/zmiany formularzy
            losuj_przycisk(Color.LightSeaGreen); //losujemy numer przycisku i dodajemy do niego kolor 
            losuj_przycisk(Color.LightSeaGreen); //16 razy wywolana funkcja bo 16 buttonow po dwa kolory takie same zeby byla para
            losuj_przycisk(Color.LightPink);
            losuj_przycisk(Color.LightPink);
            losuj_przycisk(Color.HotPink);
            losuj_przycisk(Color.HotPink); //wsystkie przyporzadkowane beda potem losowo ustawiane do przyciskow
            losuj_przycisk(Color.Violet);
            losuj_przycisk(Color.Violet);
            losuj_przycisk(Color.MediumVioletRed);
            losuj_przycisk(Color.MediumVioletRed);
            losuj_przycisk(Color.LightSalmon);
            losuj_przycisk(Color.LightSalmon);
            losuj_przycisk(Color.Indigo);
            losuj_przycisk(Color.Indigo);
            losuj_przycisk(Color.Fuchsia);
            losuj_przycisk(Color.Fuchsia);

            for (int i = 1; i < 17; i++)
            {
                zakryte[i] = true;
            }
        }
        private void button1_Click(object sender, EventArgs e) //klasê bazow¹ dla klas, które zawieraj¹ dane zdarzenia i dostarcza wartoœæ do u¿ycia dla zdarzeñ, które nie zawieraj¹ danych zdarzenia
        {
            if (button1.BackColor != kolory[1]) //teraz backcolor odpowiada kolorowi przyporzadkowanemu ( jednemu z 8)
            {
                button1.BackColor = kolory[1]; 
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 1;
                    czy_pierwszy_klik = false; //wczesniej przy ruruchominiuy gry jest true wiec jak sie kliknie to zmiana watosci
                }
                else
                {
                    numer_drugiego = 1;
                    czy_pierwszy_klik = true; // tu jest tru bo sa klikniecia true,false,true,false... i teraz znowu wypada na true
                    sprawdz(); //sprawdzenie czy traiono w pare
                    koloruj_przyciski();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e) //metoda ladujaca formsy w zakladce form1.designer, bo musi sie laczyc 
        {

        }

        private void losuj_przycisk(Color kolor) //losowanie kolorow przyciskow zapisanych na gorze
        {
            Random gen = new Random(); //genrowanie randomowej liczby
            int numer_pola = gen.Next(1, 17); //wygenerowana losowa liczba z podanego przdzialu
            while (czy_przyciski_maja_kolor[numer_pola] == true) //bedziemy tak dlugo to wykonywac az w podanej tablicy z przyporzadkowana wartoscia wyjdzie true
            {                                                    //losujemy numer pola az do tradienia na taki ktorego kolor nie byl jeszcze ustawiony
                numer_pola = gen.Next(1, 17); //mamy zmienna miedzy 1 a 16 (do zmiennej numer pola przypisywana jest ta wartosc)
            }
            czy_przyciski_maja_kolor[numer_pola] = true; //wszystkie przyciski maja juz kolory wiec jest git
            kolory[numer_pola] = kolor;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor != kolory[2])
            {
                button2.BackColor = kolory[2];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 2;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 2;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor != kolory[3])
            {
                button3.BackColor = kolory[3];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 3;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 3;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor != kolory[4])
            {
                button4.BackColor = kolory[4];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 4;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 4;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor != kolory[5])
            {
                button5.BackColor = kolory[5];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 5;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 5;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor != kolory[6])
            {
                button6.BackColor = kolory[6];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 6;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 6;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor != kolory[7])
            {
                button7.BackColor = kolory[7];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 7;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 7;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor != kolory[8])
            {
                button8.BackColor = kolory[8];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 8;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 8;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor != kolory[9])
            {
                button9.BackColor = kolory[9];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 9;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 9;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor != kolory[10])
            {
                button10.BackColor = kolory[10];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 10;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 10;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
       
        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor != kolory[11])
            {
                button11.BackColor = kolory[11];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 11;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 11;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor != kolory[12])
            {
                button12.BackColor = kolory[12];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 12;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 12;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor != kolory[13])
            {
                button13.BackColor = kolory[13];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 13;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 13;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor != kolory[14])
            {
                button14.BackColor = kolory[14];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 14;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 14;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor != kolory[15])
            {
                button15.BackColor = kolory[15];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 15;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 15;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski();
                }
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor != kolory[16])
            {
                button16.BackColor = kolory[16];
                if (czy_pierwszy_klik == true)
                {
                    numer_pierwszego = 16;
                    czy_pierwszy_klik = false;
                }
                else
                {
                    numer_drugiego = 16;
                    czy_pierwszy_klik = true;
                    sprawdz();
                    koloruj_przyciski(); //jak sprawdzone to mozemy wywowalc funkcje znajdujaca sie ponizej czyli pokolorowanie przyciskow
                }
            }
        }
        private void sprawdz() // sprawdz bylo juz na gorze, jej zadaniem jest sprawdzic czy trafilismy na pare i czy wszystkie sa juz odkryte
        {
            ruchy = ruchy + 1; // tutaj zwiekszamy ilpsc ruchow, bo czy trafimy czy ni to oznac za ze klinkelismy
            if (kolory[numer_pierwszego] == kolory[numer_drugiego])
            {
                MessageBox.Show("Brawo znalazles pare, twoja liczba ruchów wynosi: " + ruchy); //warunek jest spelniony to message box wyswietla info 
                zakryte[numer_pierwszego] = false;                                             //taki cout ale w visualu  
                zakryte[numer_drugiego] = false; 
                numer_pierwszego = 0;
                numer_drugiego = 0;
            }
            else
            {
                MessageBox.Show("Nie tym razem, Próbuj dalej"); //show pokaz w visualu w odpalonym projekcie
            }
            int odkryte = 0; //sprawdczamy tutaj czy wszystkie pary sa odkryte
            for(int j = 0; j<17; j++) //przy ruuchomieniu byla przyjmowana wartosc false wiec i przy zakonczeniu musi byc aby wszystki byly polacozne
            {
                if(zakryte[j] == false) //przechodzimy po wszyst6kich buttonach po kolei i jak ma wartosc false to dodajemy do wartosci odkrytych 
                {
                    odkryte = odkryte + 1;
                }
            }
            if( odkryte == 16) { MessageBox.Show("Gratulacje odkry³eœ wszystkie karty"); //jesli ilosc odkrtycy6ch jest rowna ilosci wszystkich to git
             odkryte = 0;
            }
        } 
        private void koloruj_przyciski() //koloruj przyc iski jak sie uda to koloruje na wyllosowany nie uda to zostaje odwrocony
        {
            {
                if(zakryte[1] == false ) {  button1.BackColor = kolory[1]; }
                else { button1.BackColor = Color.WhiteSmoke;  }

                if (zakryte[2] == false) { button2.BackColor = kolory[2]; }
                else { button2.BackColor = Color.WhiteSmoke; }

                if (zakryte[3] == false) { button3.BackColor = kolory[3]; }
                else { button3.BackColor = Color.WhiteSmoke; }

                if (zakryte[4] == false) { button4.BackColor = kolory[4]; }
                else { button4.BackColor = Color.WhiteSmoke; }

                if (zakryte[5] == false) { button5.BackColor = kolory[4]; }
                else { button5.BackColor = Color.WhiteSmoke; }

                if (zakryte[6] == false) { button6.BackColor = kolory[6]; }
                else { button6.BackColor = Color.WhiteSmoke; }

                if (zakryte[7] == false) { button7.BackColor = kolory[7]; }
                else { button7.BackColor = Color.WhiteSmoke; }

                if (zakryte[8] == false) { button8.BackColor = kolory[8]; }
                else { button8.BackColor = Color.WhiteSmoke; }

                if (zakryte[9] == false) { button9.BackColor = kolory[9]; }
                else { button9.BackColor = Color.WhiteSmoke; }

                if (zakryte[10] == false) { button1.BackColor = kolory[10]; }
                else { button10.BackColor = Color.WhiteSmoke; }

                if (zakryte[11] == false) { button11.BackColor = kolory[11]; }
                else { button11.BackColor = Color.WhiteSmoke; }

                if (zakryte[12] == false) { button12.BackColor = kolory[12]; }
                else { button12.BackColor = Color.WhiteSmoke; }

                if (zakryte[13] == false) { button13.BackColor = kolory[13]; }
                else { button13.BackColor = Color.WhiteSmoke; }

                if (zakryte[14] == false) { button14.BackColor = kolory[14]; }
                else { button14.BackColor = Color.WhiteSmoke; }

                if (zakryte[15] == false) { button15.BackColor = kolory[15]; }
                else { button15.BackColor = Color.WhiteSmoke; }

                if (zakryte[16] == false) { button16.BackColor = kolory[16]; }
                else { button16.BackColor = Color.WhiteSmoke; }
            }
        }

    }
}