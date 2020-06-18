using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qwixx
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            qwixxKaartMaken(arrayButtonKaart1, 1);
            
            // qwixxKaartMaken(arrayButtonKaart2, 12);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1250 , 700);
        }

        // meervoudige array van buttons maken.
        Button[,] arrayButtonKaart1 = new Button[4, 12];
        // Button[,] arrayButtonKaart2 = new Button[4, 12];

        // array true or false 
        bool rood = true;
        bool geel = true;
        bool groen = true;
        bool blauw = true; 

        bool[,] arrayControl = new bool[4,12];


        Random r = new Random();

        // 6 dobbelstenen onthouden
        int dobbelsteenW1, dobbelsteenW2, dobbelsteenGroen, dobbelsteenGeel, dobbelsteenBlauw, dobbelsteenRood;

        // Methode voor Qwixx kaart.
        void qwixxKaartMaken(Button [,] arrayButtonKaart, int xPositie)
        {
            int y = 1;

            // buttons in een meervoudig Array

            for (int rij = 0; rij < 4; rij++)
            {
                for (int kolom = 0; kolom < 12; kolom++)
                {
                    arrayButtonKaart[rij, kolom] = new Button();
                    Controls.Add(arrayButtonKaart[rij, kolom]);

                    switch (rij)
                    {
                        case 0:
                            arrayButtonKaart[rij, kolom].BackColor = Color.Red;
                            arrayButtonKaart[rij, kolom].Text = (kolom + 2).ToString();
                            break;

                        case 1:
                            arrayButtonKaart[rij, kolom].BackColor = Color.Yellow;
                            arrayButtonKaart[rij, kolom].Text = (kolom + 2).ToString();
                            break;

                        case 2:
                            arrayButtonKaart[rij, kolom].BackColor = Color.LimeGreen;
                            arrayButtonKaart[rij, kolom].Text = (-kolom + 12).ToString();
                            break;

                        case 3:
                            arrayButtonKaart[rij, kolom].BackColor = Color.DodgerBlue;
                            arrayButtonKaart[rij, kolom].Text = (-kolom + 12).ToString();
                            break;

                    }

                    arrayButtonKaart[rij, kolom].TextAlign = ContentAlignment.MiddleCenter;
                    arrayButtonKaart[rij, kolom].Size = new Size(40, 40);
                    arrayButtonKaart[rij, kolom].Location = new Point((kolom + xPositie) * 50, (rij + y) * 50);
                    arrayButtonKaart[rij, kolom].Click += ButtonOnClick;

                    this.Controls.Add(arrayButtonKaart[rij, kolom]);

                }
            }



            //plaatje op de laaste button 
            for ( int i = 0; i < 4; i++)
            {
                arrayButtonKaart[i, 11].BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/lockopen.png");
                arrayButtonKaart[i, 11].BackgroundImageLayout = ImageLayout.Stretch;
            }


        }
        
        // Dobbelsteen laten zien en rollen.
        int dobbelsteenLatenzien(PictureBox pb, string kleur, bool aan)
        {
            int dobbelsteen;

            dobbelsteen = r.Next(1, 7);
            if (aan == true)
            {
                switch (dobbelsteen)
                {

                    case 1:
                        pb.BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/dobbelstenen/dobbelsteen1" + kleur + ".png");
                        pb.BackgroundImageLayout = ImageLayout.Stretch;
                        break;

                    case 2:
                        pb.BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/dobbelstenen/dobbelsteen2" + kleur + ".png");
                        pb.BackgroundImageLayout = ImageLayout.Stretch;
                        break;

                    case 3:
                        pb.BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/dobbelstenen/dobbelsteen3" + kleur + ".png");
                        pb.BackgroundImageLayout = ImageLayout.Stretch;
                        break;

                    case 4:
                        pb.BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/dobbelstenen/dobbelsteen4" + kleur + ".png");
                        pb.BackgroundImageLayout = ImageLayout.Stretch;
                        break;

                    case 5:
                        pb.BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/dobbelstenen/dobbelsteen5" + kleur + ".png");
                        pb.BackgroundImageLayout = ImageLayout.Stretch;
                        break;

                    case 6:
                        pb.BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/dobbelstenen/dobbelsteen6" + kleur + ".png");
                        pb.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                }

               
            }
            else
            {
                pb.BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/crossout" + kleur + ".png");
                pb.BackgroundImageLayout = ImageLayout.Stretch;
                pb.Enabled = false;
            }
            return dobbelsteen;
        }

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            Button button = (Button) sender;
            int intIndex;

          

            if (button.BackColor == Color.Red)
            {
                intIndex = int.Parse(button.Text) - 2;
                if ( (dobbelsteenW1 + dobbelsteenW2) == intIndex + 2 || (dobbelsteenW1 + dobbelsteenRood == intIndex + 2) || (dobbelsteenW2 + dobbelsteenRood == intIndex + 2) )
                {
                    // Alle knoppen *voor* de gedrukte knop op uit zetten.
                    // intIndex is gelijk aan de positie in the array van in de rode rij.
                    arrayControl[0, intIndex] = true;
                    for (int i = 0; i < intIndex; i++)
                    {
                       if (arrayControl[0, i] == false)
                       {
                         arrayButtonKaart1[0, i].Enabled = false;
                         arrayButtonKaart1[0, i].BackColor = Color.Black;

                       }
                    }
                        
                    arrayButtonKaart1[0, intIndex].BackColor = Color.White;
                    arrayControl[0, intIndex] = true;

                    //Rij sluiten via de slot knop.
                    if (intIndex == 10)
                    {
                        arrayButtonKaart1[0, 11].BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/lockclosed.png");
                        arrayButtonKaart1[0, 11].BackgroundImageLayout = ImageLayout.Stretch;

                        rood = false;
                        imgRood.BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/crossoutrood.png");
                    }
                }
                    
                else 
                {
                  MessageBox.Show("Deze knop mag niet afgekruist worden.");
                }
                //Note: verbode vakjes worden nog steeds geteldt.
            }

            if (button.BackColor == Color.Yellow)
            {
                intIndex = int.Parse(button.Text) - 2;
                if ((dobbelsteenW1 + dobbelsteenW2) == intIndex + 2 || (dobbelsteenW1 + dobbelsteenGeel == intIndex + 2) || (dobbelsteenW2 + dobbelsteenGeel == intIndex + 2))
                {
                    arrayControl[1, intIndex] = true;
                    intIndex = int.Parse(button.Text) - 2;
                    arrayControl[1, intIndex] = true;
                    for (int i = 0; i < intIndex; i++)
                    {
                        if (arrayControl[1, i] == false)
                        {
                            arrayButtonKaart1[1, i].Enabled = false;
                            arrayButtonKaart1[1, i].BackColor = Color.Black;

                        }
                    }
                    
                    arrayButtonKaart1[1, intIndex].BackColor = Color.White;
                    arrayControl[1, intIndex] = true;

                    //Rij sluiten via de slot knop.
                    if (intIndex == 10)
                    {
                        arrayButtonKaart1[1, 11].BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/lockclosed.png");
                        arrayButtonKaart1[1, 11].BackgroundImageLayout = ImageLayout.Stretch;

                        geel = false;
                        imgGeel.BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/crossoutgeel.png");
                    }

                    else
                    {
                        MessageBox.Show("Deze knop mag niet afgekruist worden.");
                    }
                }

            }

            if (button.BackColor == Color.LimeGreen)
            {
                intIndex = 12 - int.Parse(button.Text);
                if ((dobbelsteenW1 + dobbelsteenW2) == intIndex || (dobbelsteenW1 + dobbelsteenGroen == intIndex ) || (dobbelsteenW2 + dobbelsteenGroen == intIndex ) )
                {
                    arrayControl[2, intIndex] = true;
                    // De inhoud van intIndex is lengte van de array na het aftrekken van de cijfer in de knop die in de groene rij wordt ingedrukt.
                    // Voorbeeld: 12 (lengte van de array) - 8
                    intIndex = 12 - int.Parse(button.Text);
                    arrayControl[2, intIndex] = true;
                    for (int i = 0; i < intIndex; i++)
                    {
                        // ArrayControl kijkt als de knop wel of niet al is ingedrukt.
                        if (arrayControl[2, i] == false)
                        {
                            arrayButtonKaart1[2, i].Enabled = false;
                            arrayButtonKaart1[2, i].BackColor = Color.Black;
                        }
                    }
                    
                    arrayButtonKaart1[2, intIndex].BackColor = Color.White;
                    arrayControl[2, intIndex] = true;

                    //Rij sluiten via de slot knop.
                    if (intIndex == 10)
                    {
                        arrayButtonKaart1[2, 11].BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/lockclosed.png");
                        arrayButtonKaart1[2, 11].BackgroundImageLayout = ImageLayout.Stretch;

                        groen = false;
                        imgGroen.BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/crossoutgroen.png");
                    }

                    else
                    {
                        MessageBox.Show("Deze knop mag niet afgekruist worden.");
                    }
                    //Note: verbode vakjes worden nog steeds geteldt.
                }

            }

            if (button.BackColor == Color.DodgerBlue)
            {
                // De inhoud van intIndex is lengte van de array na het aftrekken van de cijfer in de knop die in de groene rij wordt ingedrukt.
                // Voorbeeld: 12 (lengte van de array) - 8
                intIndex = 12 - int.Parse(button.Text);
                if ( (dobbelsteenW1 + dobbelsteenW2) == intIndex + 2 || (dobbelsteenW1 + dobbelsteenBlauw == intIndex + 2) || (dobbelsteenW2 + dobbelsteenBlauw == intIndex + 2))
                {
                    arrayControl[3, intIndex] = true;
                    intIndex = 12 - int.Parse(button.Text);
                    arrayControl[3, intIndex] = true;
                    for (int i = 0; i < intIndex; i++)
                    {
                        if (arrayControl[3, i] == false)
                        {
                            arrayButtonKaart1[3, i].Enabled = false;
                            arrayButtonKaart1[3, i].BackColor = Color.Black;

                        }
                    }
                    
                    arrayButtonKaart1[3, intIndex].BackColor = Color.White;
                    arrayControl[3, intIndex] = true;

                }

                if (intIndex == 10)
                {
                    arrayButtonKaart1[3, 11].BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/lockclosed.png");
                    arrayButtonKaart1[3, 11].BackgroundImageLayout = ImageLayout.Stretch;

                    // Bool die kijk als het waar is dat die bobbelsteen is uitgeschakeled en uitgeschakeled moet blijven.
                    blauw = false;
                    imgGroen.BackgroundImage = Image.FromFile(@"C:/Users/User/source/repos/Qwixx/images/crossoutblauw.png");
                }

                else
                {
                    MessageBox.Show("Deze knop mag niet afgekruist worden.");
                }

            }

        }

        
        private void btndobbelsteen_Click(object sender, EventArgs e)
        {
            dobbelsteenW1 = dobbelsteenLatenzien(imgWit1, "wit", true);
            dobbelsteenW2 = dobbelsteenLatenzien(imgWit2, "wit", true);
            dobbelsteenGroen = dobbelsteenLatenzien(imgGroen, "groen", groen);
            dobbelsteenGeel = dobbelsteenLatenzien(imgGeel, "geel", geel);
            dobbelsteenBlauw = dobbelsteenLatenzien(imgBlauw, "blauw", blauw);
            dobbelsteenRood = dobbelsteenLatenzien(imgRood, "rood", rood);
        }
    }
}
