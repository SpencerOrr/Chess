using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Chess
{
    public partial class Form1 : Form
    {

        int[] peiceLocations = new int[65];
        int[] pawnMovement = new int[17];
        int[] movment = new int[65];
        int button = 0;
        int firstButton = 0;
        bool buttonClicked = false;
        int whichButtonClicked = 0;
        int peice = 0;
        int side;
        int ogSide;
        int whichPawn;
        int row = 0;
        bool divisible = false;
        public Form1()
        {
            InitializeComponent();
            GameSetup();
        }
        public void GameSetup()
        {
            Array.Clear(peiceLocations, 0, peiceLocations.Length);
            for(int i = 1; i <= 64; i++)
            {
                this.Controls["button" + i].BackgroundImage = null;
            }
            //set up peices in correct places             
            button2.BackgroundImage = Chess.Properties.Resources.black_pawn;
            button10.BackgroundImage = Chess.Properties.Resources.black_pawn;
            button18.BackgroundImage = Chess.Properties.Resources.black_pawn;
            button26.BackgroundImage = Chess.Properties.Resources.black_pawn;
            button34.BackgroundImage = Chess.Properties.Resources.black_pawn;
            button42.BackgroundImage = Chess.Properties.Resources.black_pawn;
            button50.BackgroundImage = Chess.Properties.Resources.black_pawn;
            button58.BackgroundImage = Chess.Properties.Resources.black_pawn;

            peiceLocations[2] = 1;
            peiceLocations[10] = 1;
            peiceLocations[18] = 1;
            peiceLocations[26] = 1;
            peiceLocations[34] = 1;
            peiceLocations[42] = 1;
            peiceLocations[50] = 1;
            peiceLocations[58] = 1;

            button1.BackgroundImage = Chess.Properties.Resources.black_rook;
            button9.BackgroundImage = Chess.Properties.Resources.black_knight;
            button17.BackgroundImage = Chess.Properties.Resources.black_bishop;
            button25.BackgroundImage = Chess.Properties.Resources.black_queen;
            button33.BackgroundImage = Chess.Properties.Resources.black_king;
            button41.BackgroundImage = Chess.Properties.Resources.black_bishop;
            button49.BackgroundImage = Chess.Properties.Resources.black_knight;
            button57.BackgroundImage = Chess.Properties.Resources.black_rook;

            peiceLocations[1] = 2;
            peiceLocations[9] = 3;
            peiceLocations[17] = 4;
            peiceLocations[25] = 5;
            peiceLocations[33] = 6;
            peiceLocations[41] = 4;
            peiceLocations[49] = 3;
            peiceLocations[57] = 2;

            button7.BackgroundImage = Chess.Properties.Resources.white_pawn;
            button15.BackgroundImage = Chess.Properties.Resources.white_pawn;
            button23.BackgroundImage = Chess.Properties.Resources.white_pawn;
            button31.BackgroundImage = Chess.Properties.Resources.white_pawn;
            button39.BackgroundImage = Chess.Properties.Resources.white_pawn;
            button47.BackgroundImage = Chess.Properties.Resources.white_pawn;
            button55.BackgroundImage = Chess.Properties.Resources.white_pawn;
            button63.BackgroundImage = Chess.Properties.Resources.white_pawn;

            peiceLocations[7] = 7;
            peiceLocations[15] = 7;
            peiceLocations[23] = 7;
            peiceLocations[31] = 7;
            peiceLocations[39] = 7;
            peiceLocations[47] = 7;
            peiceLocations[55] = 7;
            peiceLocations[63] = 7;

            button8.BackgroundImage = Chess.Properties.Resources.white_rook;
            button16.BackgroundImage = Chess.Properties.Resources.white_knight;
            button24.BackgroundImage = Chess.Properties.Resources.white_bishop;
            button32.BackgroundImage = Chess.Properties.Resources.white_queen;
            button40.BackgroundImage = Chess.Properties.Resources.white_king;
            button48.BackgroundImage = Chess.Properties.Resources.white_bishop;
            button56.BackgroundImage = Chess.Properties.Resources.white_knight;
            button64.BackgroundImage = Chess.Properties.Resources.white_rook;

            peiceLocations[8] = 8;
            peiceLocations[16] = 9;
            peiceLocations[24] = 10;
            peiceLocations[32] = 11;
            peiceLocations[40] = 12;
            peiceLocations[48] = 10;
            peiceLocations[56] = 9;
            peiceLocations[64] = 8;

            // all variables set
            buttonClicked = false;
            label1.Visible = false;
            Array.Clear(pawnMovement, 0, pawnMovement.Length);
            Array.Clear(movment, 0, movment.Length);
            button = 0;
            firstButton = 0;
            buttonClicked = false;
            whichButtonClicked = 0;
            peice = 0;
            side = 0;
            ogSide = 0;
            row = 0;
            divisible = false;
            resetButton.Visible = false;

        }
        //shows posible moves for peices 
        public void peicecheck()
        {
            CheckMate();
            buttonClicked = true;
            firstButton = button;
            if (peiceLocations[button] == 1)
            {
                peice = 1;
                if (button == 2 && pawnMovement[1] == 0)
                {
                    whichPawn = 1;
                    button++;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    BlackPawnAttack();
                }
                else if (button == 10 && pawnMovement[2] == 0)
                {
                    whichPawn = 2;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    BlackPawnAttack();
                }
                else if (button == 18 && pawnMovement[3] == 0)
                {
                    whichPawn = 3;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    BlackPawnAttack();
                }
                else if (button == 26 && pawnMovement[4] == 0)
                {
                    whichPawn = 4;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    BlackPawnAttack();
                }
                else if (button == 34 && pawnMovement[5] == 0)
                {
                    whichPawn = 5;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    BlackPawnAttack();
                }
                else if (button == 42 && pawnMovement[6] == 0)
                {
                    whichPawn = 6;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    BlackPawnAttack();
                }
                else if (button == 50 && pawnMovement[7] == 0)
                {
                    whichPawn = 7;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    BlackPawnAttack();
                }
                else if (button == 58 && pawnMovement[8] == 0)
                {
                    whichPawn = 8;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    BlackPawnAttack();
                }
                else
                {
                    movment[button] = 1;
                    button++;
                    movment[button] = 1;
                    BlackPawnAttack();
                }
            }
            else if (peiceLocations[button] == 2)
            {
                peice = 2;
                side = button;
                ogSide = side;
                side = 8;
                for (side += ogSide; side <= 64; side += 8)
                {
                    if (peiceLocations[side] > 6 || peiceLocations[side] == 0)
                    {
                        movment[side] = 2;
                    }
                    else
                    {
                        side = 65;
                    }
                }
                side = -8; 
                for (side += ogSide; side >= 1; side -= 8)
                {
                    if ((side > 0 || side < 65) && (peiceLocations[side] > 6 || peiceLocations[side] == 0))
                    {
                        movment[side] = 2;
                    }
                    else
                    {
                        side = 0;
                    }
                }
                int rookDown = 1;
                RowFile();
                row--;
                rookDown = row * 8;
                button = -1;
                divisible = false;
                for (button += firstButton; button >= 1; button--)
                {
                    if (button == rookDown)
                    {
                        divisible = true;
                    }
                    if (divisible == false)
                    {
                        if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                        {
                            movment[button] = 2;
                        }
                        else
                        {
                            button = 0;
                        }
                    }
                    else if (divisible == true)
                    {
                        button = 0;

                    }
                }
                divisible = false;
                button = 1;
                for (button += firstButton; button <= 65; button++)
                {
                    if (button % 8 == 0)
                    {
                        divisible = true;
                    }
                    if (divisible == false)
                    {
                        if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                        {
                            movment[button] = 2;
                        }
                        else
                        {
                            button = 66;
                        }
                    }
                    else if (divisible == true)
                    {
                        movment[button] = 2;
                        button = 66;
                    }
                }
            }
            else if (peiceLocations[button] == 3)
            {
                //RowFile();
                //int peiceRow = row;                
                //button = button + 10;
                //RowFile();
                //if (button > 1 || button < 64 && peiceRow != row)
                //{
                //    movment[button] = 3;
                //}
                //button = firstButton;
                //button -= 6;
                //RowFile();
                //if (button > 1 || button < 64 && peiceRow != row)
                //{
                //    movment[button] = 3;
                //}
                //button = firstButton;
                //button -= 10;
                //RowFile();
                //if (button > 1 || button < 64 && peiceRow != row)
                //{
                //    movment[button] = 3;
                //}
                peice = 3;

            }
            else if (peiceLocations[button] == 4)
            {
                peice = 4;
                button = -7;
                for (button += firstButton; button >= 1; button -= 7) 
                {
                    if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                    {
                        movment[button] = 4;                                                                   
                    }
                    else
                    {
                        button = 1;
                    }
                }
                button = 7;
                for (button += firstButton; button <= 64; button += 7)
                {
                    if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                    {
                        movment[button] = 4;
                    }
                    else
                    {
                        button = 64;
                    }
                }
                button = -9;
                for (button += firstButton; button >= 1; button -= 9)
                {
                    if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                    {
                        movment[button] = 4;
                    }
                    else
                    {
                        button = 1;
                    }
                }
                button = 9;
                for (button += firstButton; button <= 64; button += 9)
                {
                    if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                    {
                        movment[button] = 4;
                    }
                    else
                    {
                        button = 64;
                    }
                }
            }
            else if (peiceLocations[button] == 5)
            {
                peice = 5;
                //diagonal movement
                button = -7;
                for (button += firstButton; button >= 1; button -= 7)
                {
                    if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                    {
                        movment[button] = 5;
                    }
                    else
                    {
                        button = 1;
                    }
                }
                button = 7;
                for (button += firstButton; button <= 64; button += 7)
                {
                    if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                    {
                        movment[button] = 5;
                    }
                    else
                    {
                        button = 64;
                    }
                }
                button = -9;
                for (button += firstButton; button >= 1; button -= 9)
                {
                    if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                    {
                        movment[button] = 5;
                    }
                    else
                    {
                        button = 1;
                    }
                }
                button = 9;
                for (button += firstButton; button <= 64; button += 9)
                {
                    if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                    {
                        movment[button] = 5;
                    }
                    else
                    {
                        button = 64;
                    }
                }
                // horezontal and vertical movment 
                button = firstButton;
                side = button;
                ogSide = side;
                side = 8;
                for (side += ogSide; side <= 64; side += 8)
                {
                    if (peiceLocations[side] > 6 || peiceLocations[side] == 0)
                    {
                        movment[side] = 5;
                    }
                    else
                    {
                        side = 65;
                    }
                }
                side = -8;
                for (side += ogSide; side >= 1; side -= 8)
                {
                    if ((side > 0 || side < 65) && (peiceLocations[side] > 6 || peiceLocations[side] == 0))
                    {
                        movment[side] = 5;
                    }
                    else
                    {
                        side = 0;
                    }
                }
                int rookDown = 1;
                RowFile();
                row--;
                rookDown = row * 8;
                button = -1;
                divisible = false;
                for (button += firstButton; button >= 1; button--)
                {
                    if (button == rookDown)
                    {
                        divisible = true;
                    }
                    if (divisible == false)
                    {
                        if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                        {
                            movment[button] = 5;
                        }
                        else
                        {
                            button = 0;
                        }
                    }
                    else if (divisible == true)
                    {
                        button = 0;

                    }
                }
                divisible = false;
                button = 1;
                for (button += firstButton; button <= 65; button++)
                {
                    if (button % 8 == 0)
                    {
                        divisible = true;
                    }
                    if (divisible == false)
                    {
                        if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                        {
                            movment[button] = 5;
                        }
                        else
                        {
                            button = 66;
                        }
                    }
                    else if (divisible == true)
                    {
                        movment[button] = 5;
                        button = 66;
                    }
                }
            }
            else if (peiceLocations[button] == 6)
            {
                peice = 6;
                button += 8;
                if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                {
                    movment[button] = 6;
                }
                button = firstButton - 8;
                if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                {
                    movment[button] = 6;
                }
                button = firstButton - 1;
                if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                {
                    movment[button] = 6;
                }
                button = firstButton + 1;
                if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                {
                    movment[button] = 6;
                }
                button = firstButton + 9;
                if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                {
                    movment[button] = 6;
                }
                button = firstButton - 9;
                if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                {
                    movment[button] = 6;
                }
                button = firstButton - 7;
                if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                {
                    movment[button] = 6;
                }
                button = firstButton + 7;
                if ((button > 0 || button < 65) && (peiceLocations[button] > 6 || peiceLocations[button] == 0))
                {
                    movment[button] = 6;
                }
            }
            else if (peiceLocations[button] == 7)
            {
                peice = 7;
                if (button == 7 && pawnMovement[8] == 0)
                {
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    pawnMovement[9] = 1;
                    WhitePawnAttack();
                }
                else if (button == 15 && pawnMovement[9] == 0)
                {
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    pawnMovement[10] = 1;
                    WhitePawnAttack();
                }
                else if (button == 23 && pawnMovement[10] == 0)
                {
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    pawnMovement[11] = 1;
                    WhitePawnAttack();
                }
                else if (button == 31 && pawnMovement[11] == 0)
                {
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    pawnMovement[12] = 1;
                    WhitePawnAttack();
                }
                else if (button == 39 && pawnMovement[12] == 0)
                {
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    pawnMovement[13] = 1;
                    WhitePawnAttack();
                }
                else if (button == 47 && pawnMovement[13] == 0)
                {
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    pawnMovement[14] = 1;
                    WhitePawnAttack();
                }
                else if (button == 55 && pawnMovement[14] == 0)
                {
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    pawnMovement[15] = 1;
                    WhitePawnAttack();
                }
                else if (button == 63 && pawnMovement[13] == 0)
                {
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    pawnMovement[16] = 1;
                    WhitePawnAttack();
                }
                else
                {
                    movment[button] = 7;
                    button--;
                    movment[button] = 7;
                    WhitePawnAttack();
                }
            }
            else if (peiceLocations[button] == 8)
            {
                peice = 8;
                side = button;
                ogSide = side;
                for (side = ogSide; side <= 64; side += 8)
                {
                    movment[side] = peice;
                }
                side = ogSide;
                for (side = ogSide; side >= 1; side -= 8)
                {
                    movment[side] = peice;
                }
                int rookDown = 1;
                RowFile();
                row--;
                rookDown = row * 8;
                button = -1;
                divisible = false;
                for (button += firstButton; button >= 1; button--)
                {
                    if (button == rookDown)
                    {
                        divisible = true;
                    }
                    if (divisible == false)
                    {
                        movment[button] = peice;
                    }
                    else if (divisible == true)
                    {
                        button = 0;

                    }
                }
                divisible = false;
                for (button = firstButton; button <= 65; button++)
                {
                    if (button % 8 == 0)
                    {
                        divisible = true;
                    }
                    if (divisible == false)
                    {
                        movment[button] = peice;
                    }
                    else if (divisible == true)
                    {
                        movment[button] = peice;
                        button = 66;
                    }
                }
            }
            else if (peiceLocations[button] == 9)
            {              
                peice = 9;
            }
            else if (peiceLocations[button] == 10)
            {
                peice = 10;
                for (button = firstButton; button >= 1; button -= 7)
                {
                    if (button > 0 || button < 65)
                    {
                        movment[button] = peice;
                    }
                }
                for (button = firstButton; button <= 64; button += 7)
                {
                    if (button > 0 || button < 65)
                    {
                        movment[button] = peice;
                    }
                }
                for (button = firstButton; button >= 1; button -= 9)
                {
                    if (button > 0 || button < 65)
                    {
                        movment[button] = peice;
                    }
                }
                for (button = firstButton; button <= 64; button += 9)
                {
                    if (button > 0 || button < 65)
                    {
                        movment[button] = peice;
                    }
                }
            }
            else if (peiceLocations[button] == 11)
            {
                peice = 11;
                button = firstButton;
                for (button = firstButton; button >= 1; button -= 7)
                {
                    if (button > 0 || button < 65)
                    {
                        movment[button] = peice;
                    }
                }
                for (button = firstButton; button <= 64; button += 7)
                {
                    if (button > 0 || button < 65)
                    {
                        movment[button] = peice;
                    }
                }
                for (button = firstButton; button >= 1; button -= 9)
                {
                    if (button > 0 || button < 65)
                    {
                        movment[button] = peice;
                    }
                }
                for (button = firstButton; button <= 64; button += 9)
                {
                    if (button > 0 || button < 65)
                    {
                        movment[button] = peice;
                    }
                }
                button = firstButton;
                side = button;
                ogSide = side;
                for (side = ogSide; side <= 64; side += 8)
                {
                    movment[side] = peice;
                }
                side = ogSide;
                button = firstButton;
                for (side = ogSide; side >= 1; side -= 8)
                {
                    movment[side] = peice;
                }
                int rookDown = 1;
                RowFile();
                row--;
                rookDown = row * 8;
                button = -1;
                divisible = false;
                for (button += firstButton; button >= 1; button--)
                {
                    if (button == rookDown)
                    {
                        divisible = true;
                    }
                    if (divisible == false)
                    {
                        movment[button] = peice;
                    }
                    else if (divisible == true)
                    {
                        button = 0;

                    }
                }
                divisible = false;
                for (button = firstButton; button <= 65; button++)
                {
                    if (button % 8 == 0)
                    {
                        divisible = true;
                    }
                    if (divisible == false)
                    {
                        movment[button] = peice;
                    }
                    else if (divisible == true)
                    {
                        movment[button] = peice;
                        button = 66;
                    }
                }
            }
            else if (peiceLocations[button] == 12)
            {
                peice = 12;
                button += 8;
                if (button > 0 || button < 65)
                {
                    movment[button] = peice;
                }
                button = firstButton - 8;
                if (button > 0 || button < 65)
                {
                    movment[button] = peice;
                }
                button = firstButton - 1;
                if (button > 0 || button < 65)
                {
                    movment[button] = peice;
                }
                button = firstButton + 1;
                if (button > 0 || button < 65)
                {
                    movment[button] = peice;
                }
                button = firstButton + 9;
                if (button > 0 || button < 65)
                {
                    movment[button] = peice;
                }
                button = firstButton - 9;
                if (button > 0 || button < 65)
                {
                    movment[button] = peice;
                }
                button = firstButton - 7;
                if (button > 0 || button < 65)
                {
                    movment[button] = peice;
                }
                button = firstButton + 7;
                if (button > 0 || button < 65)
                {
                    movment[button] = peice;
                }
            }
            else
            {
                buttonClicked = false;
            }
        }
        public void MovePeice()
        {
            if (peice == 1)
            {
                if (movment[whichButtonClicked] == 1 )
                {
                    this.Controls["button" + firstButton].BackgroundImage = null;
                    this.Controls["button" + whichButtonClicked].BackgroundImage = Chess.Properties.Resources.black_pawn;
                    peiceLocations[firstButton] = 0;
                    peiceLocations[whichButtonClicked] = 1;
                    firstButton = whichButtonClicked;
                    pawnMovement[whichPawn] = 1;
                }
            }
            if (peice == 2)
            {
                if (movment[whichButtonClicked] == 2)
                {
                    this.Controls["button" + firstButton].BackgroundImage = null;
                    this.Controls["button" + whichButtonClicked].BackgroundImage = Chess.Properties.Resources.black_rook;
                    peiceLocations[firstButton] = 0;
                    peiceLocations[whichButtonClicked] = 2;
                    firstButton = whichButtonClicked;
                }
            }
            if (peice == 3)
            {
                this.Controls["button" + firstButton].BackgroundImage = null;
                this.Controls["button" + whichButtonClicked].BackgroundImage = Chess.Properties.Resources.black_knight;
                peiceLocations[firstButton] = 0;
                peiceLocations[whichButtonClicked] = 3;
                firstButton = whichButtonClicked;
            }
            if (peice == 4)
            {
                if (movment[whichButtonClicked] == 4)
                {
                    this.Controls["button" + firstButton].BackgroundImage = null;
                    this.Controls["button" + whichButtonClicked].BackgroundImage = Chess.Properties.Resources.black_bishop;
                    peiceLocations[firstButton] = 0;
                    peiceLocations[whichButtonClicked] = 4;
                    firstButton = whichButtonClicked;
                }
            }
            if (peice == 5)
            {
                if (movment[whichButtonClicked] == 5)
                {
                    this.Controls["button" + firstButton].BackgroundImage = null;
                    this.Controls["button" + whichButtonClicked].BackgroundImage = Chess.Properties.Resources.black_queen;
                    peiceLocations[firstButton] = 0;
                    peiceLocations[whichButtonClicked] = 5;
                    firstButton = whichButtonClicked;
                }
            }
            if (peice == 6)
            {
                if (movment[whichButtonClicked] == 6)
                {
                    this.Controls["button" + firstButton].BackgroundImage = null;
                    this.Controls["button" + whichButtonClicked].BackgroundImage = Chess.Properties.Resources.black_king;
                    peiceLocations[firstButton] = 0;
                    peiceLocations[whichButtonClicked] = 6;
                    firstButton = whichButtonClicked;
                }
            }
            if (peice == 7)
            {
                if (movment[whichButtonClicked] == 7)
                {
                    this.Controls["button" + firstButton].BackgroundImage = null;
                    this.Controls["button" + whichButtonClicked].BackgroundImage = Chess.Properties.Resources.white_pawn;
                    peiceLocations[firstButton] = 0;
                    peiceLocations[whichButtonClicked] = 7;
                    firstButton = whichButtonClicked;
                }
            }
            if (peice == 8)
            {
                if (movment[whichButtonClicked] == 8)
                {
                    this.Controls["button" + firstButton].BackgroundImage = null;
                    this.Controls["button" + whichButtonClicked].BackgroundImage = Chess.Properties.Resources.white_rook;
                    peiceLocations[firstButton] = 0;
                    peiceLocations[whichButtonClicked] = 8;
                    firstButton = whichButtonClicked;
                }
            }
            if (peice == 9)
            {
                this.Controls["button" + firstButton].BackgroundImage = null;
                this.Controls["button" + whichButtonClicked].BackgroundImage = Chess.Properties.Resources.white_knight;
                peiceLocations[firstButton] = 0;
                peiceLocations[whichButtonClicked] = 9;
                firstButton = whichButtonClicked;
            }
            if (peice == 10)
            {
                if (movment[whichButtonClicked] == 10)
                {
                    this.Controls["button" + firstButton].BackgroundImage = null;
                    this.Controls["button" + whichButtonClicked].BackgroundImage = Chess.Properties.Resources.white_bishop;
                    peiceLocations[firstButton] = 0;
                    peiceLocations[whichButtonClicked] = 10;
                    firstButton = whichButtonClicked;
                }
            }
            if (peice == 11)
            {
                if (movment[whichButtonClicked] == 11)
                {
                    this.Controls["button" + firstButton].BackgroundImage = null;
                    this.Controls["button" + whichButtonClicked].BackgroundImage = Chess.Properties.Resources.white_queen;
                    peiceLocations[firstButton] = 0;
                    peiceLocations[whichButtonClicked] = 11;
                    firstButton = whichButtonClicked;
                }
            }
            if (peice == 12)
            {
                if (movment[whichButtonClicked] == 12)
                {
                    this.Controls["button" + firstButton].BackgroundImage = null;
                    this.Controls["button" + whichButtonClicked].BackgroundImage = Chess.Properties.Resources.white_king;
                    peiceLocations[firstButton] = 0;
                    peiceLocations[whichButtonClicked] = 12;
                    firstButton = whichButtonClicked;
                }
            }
            Array.Clear(movment, 0, movment.Length);
            buttonClicked = false;
            CheckMate();
        }
        public void RowFile()
        {
            if (button <= 8)
            {
                row = 1;
            }
            else if (button <= 16)
            {
                row = 2;
            }
            else if (button <= 24)
            {
                row = 3;
            }
            else if (button <= 32)
            {
                row = 4;
            }
            else if (button <= 40)
            {
                row = 5;
            }
            else if (button <= 48)
            {
                row = 6;
            }
            else if (button <= 56)
            {
                row = 7;
            }
            else if (button <= 64)
            {
                row = 8;
            }
        }
        public void WhitePawnAttack() 
        {
            button = firstButton;
            button += 7;
            if (button > 0 && button < 65)
            {
                movment[button] = 7;
            }
            button = firstButton;
            button -= 9;
            if (button > 0 && button < 65)
            {
                movment[button] = 7;
            }

        }
        public void BlackPawnAttack()
        {
            button = firstButton;
            button -= 7;
            if (button > 0 && button < 65)
            {
                movment[button] = 1;
            }
            button = firstButton;
            button += 9;
            if (button > 0 && button < 65)
            {
                movment[button] = 1;
            }

        }
        public void CheckMate()
        {
            if (peiceLocations.Contains(6) == false)
            {
                label1.Visible = true;
                resetButton.Visible = true;
                label1.Text = "Game Over";
            }
            if (peiceLocations.Contains(12) == false)
            {
                label1.Visible = true;
                resetButton.Visible = true;
                label1.Text = "Game Over";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 1;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 1;
                MovePeice();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 2;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 2;
                MovePeice();
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 3;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 3;
                MovePeice();
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 4;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 4;
                MovePeice();
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 5;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 5;
                MovePeice();
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 6;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 6;
                MovePeice();
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 7;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 7;
                MovePeice();
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 8;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 8;
                MovePeice();
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 9;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 9;
                MovePeice();
            }

        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 10;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 10;
                MovePeice();
            }

        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 11;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 11;
                MovePeice();
            }

        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 12;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 12;
                MovePeice();
            }

        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 13;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 13;
                MovePeice();
            }

        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 14;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 14;
                MovePeice();
            }

        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 15;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 15;
                MovePeice();
            }

        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 16;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 16;
                MovePeice();
            }

        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 17;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 17;
                MovePeice();
            }

        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 18;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 18;
                MovePeice();
            }

        }
        private void button19_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 19;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 19;
                MovePeice();
            }

        }
        private void button20_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 20;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 20;
                MovePeice();
            }

        }
        private void button21_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 21;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 21;
                MovePeice();
            }

        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 22;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 22;
                MovePeice();
            }

        }
        private void button23_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 23;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 23;
                MovePeice();
            }

        }
        private void button24_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 24;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 24;
                MovePeice();
            }

        }
        private void button25_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 25;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 25;
                MovePeice();
            }

        }
        private void button26_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 26;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 26;
                MovePeice();
            }

        }
        private void button27_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 27;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 27;
                MovePeice();
            }

        }
        private void button28_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 28;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 28;
                MovePeice();
            }

        }
        private void button29_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 29;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 29;
                MovePeice();
            }

        }
        private void button30_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 30;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 30;
                MovePeice();
            }

        }
        private void button31_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 31;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 31;
                MovePeice();
            }

        }
        private void button32_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 32;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 32;
                MovePeice();
            }

        }
        private void button33_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 33;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 33;
                MovePeice();
            }

        }
        private void button34_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 34;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 34;
                MovePeice();
            }

        }
        private void button35_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 35;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 35;
                MovePeice();
            }

        }
        private void button36_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 36;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 36;
                MovePeice();
            }

        }
        private void button37_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 37;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 37;
                MovePeice();
            }

        }
        private void button38_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 38;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 38;
                MovePeice();
            }

        }
        private void button39_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 39;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 39;
                MovePeice();
            }

        }
        private void button40_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 40;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 40;
                MovePeice();
            }

        }
        private void button41_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 41;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 41;
                MovePeice();
            }

        }
        private void button42_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 42;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 42;
                MovePeice();
            }

        }
        private void button43_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 43;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 43;
                MovePeice();
            }

        }
        private void button44_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 44;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 44;
                MovePeice();
            }

        }
        private void button45_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 45;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 45;
                MovePeice();
            }

        }
        private void button46_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 46;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 46;
                MovePeice();
            }

        }
        private void button47_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 47;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 47;
                MovePeice();
            }

        }
        private void button48_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 48;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 48;
                MovePeice();
            }

        }
        private void button49_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 49;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 49;
                MovePeice();
            }

        }
        private void button50_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 50;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 50;
                MovePeice();
            }

        }
        private void button51_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 51;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 51;
                MovePeice();
            }

        }
        private void button52_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 52;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 52;
                MovePeice();
            }

        }
        private void button53_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 53;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 53;
                MovePeice();
            }

        }
        private void button54_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 54;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 54;
                MovePeice();
            }

        }
        private void button55_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 55;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 55;
                MovePeice();
            }

        }
        private void button56_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 56;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 56;
                MovePeice();
            }

        }
        private void button57_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 57;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 57;
                MovePeice();
            }

        }
        private void button58_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 58;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 58;
                MovePeice();
            }

        }
        private void button59_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 59;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 59;
                MovePeice();
            }

        }
        private void button60_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 60;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 60;
                MovePeice();
            }

        }
        private void button61_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 61;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 61;
                MovePeice();
            }

        }
        private void button62_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 62;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 62;
                MovePeice();
            }

        }
        private void button63_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 63;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 63;
                MovePeice();
            }

        }
        private void button64_Click(object sender, EventArgs e)
        {
            if (buttonClicked == false)
            {
                button = 64;
                peicecheck();
            }
            else
            {
                whichButtonClicked = 64;
                MovePeice();
            }

        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            GameSetup();
        }
    }
}
