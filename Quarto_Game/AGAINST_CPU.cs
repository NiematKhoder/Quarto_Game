using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using WMPLib;
namespace Quarto_Game
{
    public partial class AGAINST_CPU : Form
    {
        bool there_is_a_winner = false;
        PictureBox[,] board;
        ArrayList arrpieces = new ArrayList();
        ArrayList arrboard = new ArrayList();
        bool turn1;//for player

        static int counts1, counts2, Round_count, minutes, seconds, volume, count_sound;
        static string player, First_Move, lang;
        int t = -1;
        static Form form1, form2;
        string txt;

        PictureBox[] pic;
        PictureBox[] k;
        WindowsMediaPlayer sound_button = new WindowsMediaPlayer();
        WindowsMediaPlayer pieces_sound = new WindowsMediaPlayer();
        WindowsMediaPlayer music = new WindowsMediaPlayer();
        public AGAINST_CPU()
        {
            InitializeComponent();
        }

        private PictureBox look_for_win_lines(PictureBox p)
        {
            PictureBox place = null;
            ArrayList arrdiag1 = new ArrayList(3);
            ArrayList arrayList_lines1 = new ArrayList(3);
            ArrayList arrayList_lines2 = new ArrayList(3);
            ArrayList arrayList_lines3 = new ArrayList(3);
            ArrayList arrayList_lines4 = new ArrayList(3);

            int c;
            for (c = 0; c < 4; c++)
            {
                if (!board[0, c].Enabled) arrayList_lines1.Add(board[0, c]);
                if (!board[1, c].Enabled) arrayList_lines2.Add(board[1, c]);
                if (!board[2, c].Enabled) arrayList_lines3.Add(board[2, c]);
                if (!board[3, c].Enabled) arrayList_lines4.Add(board[3, c]);
                if (!board[c, c].Enabled) arrdiag1.Add(board[c, c]);
            }
            if(arrdiag1 .Count == 3)
            {
                arrdiag1 .Add(p);
                place = chek_win(arrdiag1);
                if (place == arrdiag1[3])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[c, c].Enabled)
                            return board[c, c];
                    }
                }
            }
            if (arrayList_lines1.Count == 3)
            {
                arrayList_lines1.Add(p);
                place = chek_win(arrayList_lines1);
                if (place == arrayList_lines1[3])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[0, c].Enabled)
                            return board[0, c];
                    }
                }
            }

            if (arrayList_lines2.Count == 3)
            {
                arrayList_lines2.Add(p);
                place = chek_win(arrayList_lines2);
                if (place == arrayList_lines2[3])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[1, c].Enabled)
                            return board[1, c];
                    }
                }
            }

            if (arrayList_lines3.Count == 3)
            {
                arrayList_lines3.Add(p);
                place = chek_win(arrayList_lines3);
                if (place == arrayList_lines3[3])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[2, c].Enabled)
                            return board[2, c];
                    }
                }
            }

            if (arrayList_lines4.Count == 3)
            {
                arrayList_lines4.Add(p);
                place = chek_win(arrayList_lines4);
                if (place == arrayList_lines4[3])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[3, c].Enabled)
                            return board[3, c];
                    }
                }
            }


            return null;
        }
        private PictureBox look_for_win_colomns(PictureBox p)
        {
            PictureBox place = null;
            ArrayList arrdiag2 = new ArrayList(3);
            ArrayList arrayList_lines1 = new ArrayList(3);
            ArrayList arrayList_lines2 = new ArrayList(3);
            ArrayList arrayList_lines3 = new ArrayList(3);
            ArrayList arrayList_lines4 = new ArrayList(3);

            int c;
            for (c = 0; c < 4; c++)
            {
                if (!board[c, 0].Enabled) arrayList_lines1.Add(board[c, 0]);
                if (!board[c, 1].Enabled) arrayList_lines2.Add(board[c, 1]);
                if (!board[c, 2].Enabled) arrayList_lines3.Add(board[c, 2]);
                if (!board[c, 3].Enabled) arrayList_lines4.Add(board[c, 3]);
                if (!board[c, 3-c].Enabled) arrdiag2 .Add(board[c, 3-c]);
            }
            if (arrdiag2.Count == 3)
            {
                arrdiag2 .Add(p);
                place = chek_win(arrdiag2 );
                if (place == arrdiag2[3])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[c, 3-c].Enabled)
                            return board[c, 3-c];
                    }
                }
            }
            if (arrayList_lines1.Count == 3)
            {
                arrayList_lines1.Add(p);
                place = chek_win(arrayList_lines1);
                if (place == arrayList_lines1[3])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[c, 0].Enabled)
                            return board[c, 0];
                    }
                }
            }

            if (arrayList_lines2.Count == 3)
            {
                arrayList_lines2.Add(p);
                place = chek_win(arrayList_lines2);
                if (place == arrayList_lines2[3])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[c, 1].Enabled)
                            return board[c, 1];
                    }
                }
            }

            if (arrayList_lines3.Count == 3)
            {
                arrayList_lines3.Add(p);
                place = chek_win(arrayList_lines3);
                if (place == arrayList_lines3[3])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[c, 2].Enabled)
                            return board[c, 2];
                    }
                }
            }

            if (arrayList_lines4.Count == 3)
            {
                arrayList_lines4.Add(p);
                place = chek_win(arrayList_lines4);
                if (place == arrayList_lines4[3])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[c, 3].Enabled)
                            return board[c, 3];
                    }
                }
            }


            return null;
        }
        private PictureBox BUILD_WIN_lines(PictureBox p)
        {
            PictureBox place = null;
            ArrayList arrdiag1 = new ArrayList(3);
            ArrayList arrayList_lines1 = new ArrayList(3);
            ArrayList arrayList_lines2 = new ArrayList(3);
            ArrayList arrayList_lines3 = new ArrayList(3);
            ArrayList arrayList_lines4 = new ArrayList(3);


            int c;
            for (c = 0; c < 4; c++)
            {
                if (!board[0, c].Enabled) arrayList_lines1.Add(board[0, c]);
                if (!board[1, c].Enabled) arrayList_lines2.Add(board[1, c]);
                if (!board[2, c].Enabled) arrayList_lines3.Add(board[2, c]);
                if (!board[3, c].Enabled) arrayList_lines4.Add(board[3, c]);
                if (!board[c, c].Enabled) arrdiag1 .Add(board[c, c]);
            }
            if (arrdiag1 .Count == 2)
            {
                arrdiag1 .Add(p);
                place = chek_win2(arrdiag1 );
                if (place == arrdiag1 [2])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[c, c].Enabled)
                            return board[c, c];
                    }
                }
            }
            if (arrayList_lines1.Count == 2)
            {
                arrayList_lines1.Add(p);
                place = chek_win2(arrayList_lines1);
                if (place == arrayList_lines1[2])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[0, c].Enabled)
                            return board[0, c];
                    }
                }
            }

            if (arrayList_lines2.Count == 2)
            {
                arrayList_lines2.Add(p);
                place = chek_win2(arrayList_lines2);
                if (place == arrayList_lines2[2])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[1, c].Enabled)
                            return board[1, c];
                    }
                }
            }

            if (arrayList_lines3.Count == 2)
            {
                arrayList_lines3.Add(p);
                place = chek_win2(arrayList_lines3);
                if (place == arrayList_lines3[2])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[2, c].Enabled)
                            return board[2, c];
                    }
                }
            }

            if (arrayList_lines4.Count == 2)
            {
                arrayList_lines4.Add(p);
                place = chek_win2(arrayList_lines4);
                if (place == arrayList_lines4[2])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[3, c].Enabled)
                            return board[3, c];
                    }
                }
            }


            return null;
        }
        private PictureBox BUILD_WIN_colomns(PictureBox p)
        {
            PictureBox place = null;
            ArrayList arrdiag2 = new ArrayList(3);
            ArrayList arrayList_lines1 = new ArrayList(3);
            ArrayList arrayList_lines2 = new ArrayList(3);
            ArrayList arrayList_lines3 = new ArrayList(3);
            ArrayList arrayList_lines4 = new ArrayList(3);

            int c;
            for (c = 0; c < 4; c++)
            {
                if (!board[c, 0].Enabled) arrayList_lines1.Add(board[c, 0]);
                if (!board[c, 1].Enabled) arrayList_lines2.Add(board[c, 1]);
                if (!board[c, 2].Enabled) arrayList_lines3.Add(board[c, 2]);
                if (!board[c, 3].Enabled) arrayList_lines4.Add(board[c, 3]);
                if (!board[c, 3-c].Enabled) arrdiag2 .Add(board[c, 3-c]);

            }

            if (arrdiag2 .Count == 2)
            {
                arrdiag2 .Add(p);
                place = chek_win2(arrdiag2 );
                if (place == arrdiag2 [2])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[c, 3-c].Enabled)
                            return board[c, 3-c];
                    }
                }
            }
            if (arrayList_lines1.Count == 2)
            {
                arrayList_lines1.Add(p);
                place = chek_win2(arrayList_lines1);
                if (place == arrayList_lines1[2])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[c, 0].Enabled)
                            return board[c, 0];
                    }
                }
            }

            if (arrayList_lines2.Count == 2)
            {
                arrayList_lines2.Add(p);
                place = chek_win2(arrayList_lines2);
                if (place == arrayList_lines2[2])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[c, 1].Enabled)
                            return board[c, 1];
                    }
                }
            }

            if (arrayList_lines3.Count == 2)
            {
                arrayList_lines3.Add(p);
                place = chek_win2(arrayList_lines3);
                if (place == arrayList_lines3[2])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[c, 2].Enabled)
                            return board[c, 2];
                    }
                }
            }

            if (arrayList_lines4.Count == 2)
            {
                arrayList_lines4.Add(p);
                place = chek_win2(arrayList_lines4);
                if (place == arrayList_lines4[2])
                {
                    for (c = 0; c < 4; c++)
                    {
                        if (board[c, 3].Enabled)
                            return board[c, 3];
                    }
                }
            }


            return null;
        }
        private ArrayList Three_Pieces_Lines()
        {
            ArrayList pieces_not_to_choose = new ArrayList();
            PictureBox p;
            ArrayList arrayList_lines1 = new ArrayList(3);
            ArrayList arrayList_lines2 = new ArrayList(3);
            ArrayList arrayList_lines3 = new ArrayList(3);
            ArrayList arrayList_lines4 = new ArrayList(3);
            ArrayList arrdiag1 = new ArrayList(3);
            ArrayList arrdiag2 = new ArrayList(3);


            int c;
            for (c = 0; c < 4; c++)
            {
                if (!board[0, c].Enabled) arrayList_lines1.Add(board[0, c]);
                if (!board[1, c].Enabled) arrayList_lines2.Add(board[1, c]);
                if (!board[2, c].Enabled) arrayList_lines3.Add(board[2, c]);
                if (!board[3, c].Enabled) arrayList_lines4.Add(board[3, c]);
                if (!board[c, c].Enabled) arrdiag1 .Add(board[c, c]);
                if (!board[c,3- c].Enabled) arrdiag2.Add(board[c,3- c]);

            }
            if (arrdiag1 .Count == 3)
            {
                for (int j = 0; j < arrpieces  .Count; j++)
                {
                    arrdiag1 .Add(arrpieces[j]);
                    p = chek_win(arrdiag1 );
                    if (p == arrdiag1 [3]) pieces_not_to_choose.Add(p);
                    arrdiag1 .Remove(arrpieces[j]);
                }
            }
            if (arrdiag2 .Count == 3)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrdiag2 .Add(arrpieces[j]);
                    p = chek_win(arrdiag2);
                    if (p == arrdiag2 [3]) pieces_not_to_choose.Add(p);
                    arrdiag2 .Remove(arrpieces[j]);
                }
            }
            if (arrayList_lines1.Count == 3)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_lines1.Add(arrpieces[j]);
                    p = chek_win(arrayList_lines1);
                    if (p == arrayList_lines1[3]) pieces_not_to_choose.Add(p);
                    arrayList_lines1.Remove(arrpieces[j]);
                }
            }
            if (arrayList_lines2.Count == 3)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_lines2.Add(arrpieces[j]);
                    p = chek_win(arrayList_lines2);
                    if (p ==arrayList_lines2[3]) pieces_not_to_choose.Add(p);
                    arrayList_lines2.Remove(arrpieces[j]);
                }
            }

            if (arrayList_lines3.Count == 3)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_lines3.Add(arrpieces[j]);
                    p = chek_win(arrayList_lines3);
                    if (p ==arrayList_lines3[3]) pieces_not_to_choose.Add(p);
                    arrayList_lines3.Remove(arrpieces[j]);
                }
            }
            if (arrayList_lines4.Count == 3)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_lines4.Add(arrpieces[j]);
                    p = chek_win(arrayList_lines4);
                    if (p ==arrayList_lines4[3]) pieces_not_to_choose.Add(p);
                    arrayList_lines4.Remove(arrpieces[j]);
                }
            }
            return pieces_not_to_choose;
        }

        private ArrayList Two_Pieces_Lines()
        {
            ArrayList pieces_to_choose = new ArrayList();
            PictureBox p;

            ArrayList arrayList_lines1 = new ArrayList(3);
            ArrayList arrayList_lines2 = new ArrayList(3);
            ArrayList arrayList_lines3 = new ArrayList(3);
            ArrayList arrayList_lines4 = new ArrayList(3);
            ArrayList arrdiag1 = new ArrayList(3);
            ArrayList arrdiag2 = new ArrayList(3);
            int c;
            for (c = 0; c < 4; c++)
            {
                if (!board[0, c].Enabled) arrayList_lines1.Add(board[0, c]);
                if (!board[1, c].Enabled) arrayList_lines2.Add(board[1, c]);
                if (!board[2, c].Enabled) arrayList_lines3.Add(board[2, c]);
                if (!board[3, c].Enabled) arrayList_lines4.Add(board[3, c]);
                if (!board[c, c].Enabled) arrdiag1.Add(board[c, c]);
                if (!board[c, 3 - c].Enabled) arrdiag2.Add(board[c, 3 - c]);
            }
            if (arrdiag1.Count == 2)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrdiag1 .Add(arrpieces[j]);
                    p = chek_win2(arrdiag1);
                    if (p == arrdiag1 [2]) pieces_to_choose.Add(p);
                    arrdiag1 .Remove(arrpieces[j]);
                }
            }
            if (arrdiag2.Count == 2)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrdiag2 .Add(arrpieces[j]);
                    p = chek_win2(arrdiag2);
                    if (p == arrdiag2 [2]) pieces_to_choose.Add(p);
                    arrdiag2 .Remove(arrpieces[j]);
                }
            }
            if (arrayList_lines1.Count == 2)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_lines1.Add(arrpieces[j]);
                    p = chek_win2(arrayList_lines1);
                    if (p == arrayList_lines1[2]) pieces_to_choose.Add(p);
                    arrayList_lines1.Remove(arrpieces[j]);
                }
            }
            if (arrayList_lines2.Count == 2)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_lines2.Add(arrpieces[j]);
                    p = chek_win2(arrayList_lines2);
                    if (p == arrayList_lines2[2]) pieces_to_choose.Add(p);
                    arrayList_lines2.Remove(arrpieces[j]);
                }
            }
            if (arrayList_lines3.Count == 2)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_lines3.Add(arrpieces[j]);
                    p = chek_win2(arrayList_lines3);
                    if (p == arrayList_lines3[2]) pieces_to_choose.Add(p);
                    arrayList_lines3.Remove(arrpieces[j]);
                }
            }
            if (arrayList_lines4.Count == 2)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_lines4.Add(arrpieces[j]);
                    p = chek_win2(arrayList_lines4);
                    if (p == arrayList_lines4[2]) pieces_to_choose.Add(p);
                    arrayList_lines4.Remove(arrpieces[j]);
                }
            }
            return pieces_to_choose;
        }

        private ArrayList Three_Pieces_colomns()
        {
            ArrayList pieces_not_to_choose = new ArrayList();
            PictureBox p;
            ArrayList arrayList_colomns1 = new ArrayList(3);
            ArrayList arrayList_colomns2 = new ArrayList(3);
            ArrayList arrayList_colomns3 = new ArrayList(3);
            ArrayList arrayList_colomns4 = new ArrayList(3);
            int l;
            for (l = 0; l < 4; l++)
            {
                if (!board[l, 0].Enabled) arrayList_colomns1.Add(board[l, 0]);
                if (!board[l, 1].Enabled) arrayList_colomns2.Add(board[l, 1]);
                if (!board[l, 2].Enabled) arrayList_colomns3.Add(board[l, 2]);
                if (!board[l, 3].Enabled) arrayList_colomns4.Add(board[l, 3]);
            }
            if (arrayList_colomns1.Count == 3)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_colomns1.Add(arrpieces[j]);
                    p = chek_win(arrayList_colomns1);
                    if (p == arrayList_colomns1[3]) pieces_not_to_choose.Add(p);
                    arrayList_colomns1.Remove(arrpieces[j]);
                }
            }
            if (arrayList_colomns2.Count == 3)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_colomns2.Add(arrpieces[j]);
                    p = chek_win(arrayList_colomns2);
                    if (p == arrayList_colomns2[3]) pieces_not_to_choose.Add(p);
                    arrayList_colomns2.Remove(arrpieces[j]);
                }
            }
            if (arrayList_colomns3.Count == 3)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_colomns3.Add(arrpieces[j]);
                    p = chek_win(arrayList_colomns3);
                    if (p == arrayList_colomns3[3]) pieces_not_to_choose.Add(p);
                    arrayList_colomns3.Remove(arrpieces[j]);
                }
            }
            else if (arrayList_colomns4.Count == 3)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_colomns4.Add(arrpieces[j]);
                    p = chek_win(arrayList_colomns4);
                    if (p == arrayList_colomns4[3]) pieces_not_to_choose.Add(p);
                    arrayList_colomns4.Remove(arrpieces[j]);
                }
            }
            return pieces_not_to_choose;
        }

        private ArrayList Two_Pieces_colomns()
        {

            ArrayList pieces_to_choose = new ArrayList();
            PictureBox p;
            ArrayList arrayList_colomns1 = new ArrayList(3);
            ArrayList arrayList_colomns2 = new ArrayList(3);
            ArrayList arrayList_colomns3 = new ArrayList(3);
            ArrayList arrayList_colomns4 = new ArrayList(3);
       
            int l;
            for (l = 0; l < 4; l++)
            {
                if (!board[l, 0].Enabled) arrayList_colomns1.Add(board[l, 0]);
                if (!board[l, 1].Enabled) arrayList_colomns2.Add(board[l, 1]);
                if (!board[l, 2].Enabled) arrayList_colomns3.Add(board[l, 2]);
                if (!board[l, 3].Enabled) arrayList_colomns4.Add(board[l, 3]);
            }
            if (arrayList_colomns1.Count == 2)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_colomns1.Add(arrpieces[j]);
                    p = chek_win2(arrayList_colomns1);
                    if (p == arrayList_colomns1[2]) pieces_to_choose.Add(p);
                    arrayList_colomns1.Remove(arrpieces[j]);
                }
            }
            if (arrayList_colomns2.Count == 2)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_colomns2.Add(arrpieces[j]);
                    p = chek_win2(arrayList_colomns2);
                    if (p == arrayList_colomns2[2]) pieces_to_choose.Add(p);
                    arrayList_colomns2.Remove(arrpieces[j]);
                }
            }
            if (arrayList_colomns3.Count == 2)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_colomns3.Add(arrpieces[j]);
                    p = chek_win2(arrayList_colomns3);
                    if (p == arrayList_colomns3[2]) pieces_to_choose.Add(p);
                    arrayList_colomns3.Remove(arrpieces[j]);
                }
            }
            if (arrayList_colomns4.Count == 2)
            {
                for (int j = 0; j < arrpieces.Count; j++)
                {
                    arrayList_colomns4.Add(arrpieces[j]);
                    p = chek_win2(arrayList_colomns4);
                    if (p == arrayList_colomns4[2]) pieces_to_choose.Add(p);
                    arrayList_colomns4.Remove(arrpieces[j]);
                }
            }
            return pieces_to_choose;
        }
        private PictureBox chek_win(ArrayList arr)
        {
            figure m, n, o, q;


            m = (figure)(((PictureBox)arr[0]).Tag);
            n = (figure)(((PictureBox)arr[1]).Tag);
            o = (figure)(((PictureBox)arr[2]).Tag);
            q = (figure)(((PictureBox)arr[3]).Tag);

            if ((m.color == n.color) && (n.color == o.color) && (o.color == q.color))
            {
                return ((PictureBox)arr[3]);
            }
            else if ((m.shape == n.shape) && (n.shape == o.shape) && (o.shape == q.shape))
            {
                return ((PictureBox)arr[3]);
            }
            else if ((m.size == n.size) && (n.size == o.size) && (o.size == q.size))
            {
                return ((PictureBox)arr[3]);
            }
            else if ((m.hole == n.hole) && (n.hole == o.hole) && (o.hole == q.hole))
            {
                return ((PictureBox)arr[3]);
            }

            else return null;
        }
        private PictureBox chek_win2(ArrayList arr)
        {
            figure m, n, o;


            m = (figure)(((PictureBox)arr[0]).Tag);
            n = (figure)(((PictureBox)arr[1]).Tag);
            o = (figure)(((PictureBox)arr[2]).Tag);
          

            if ((m.color == n.color) && (n.color == o.color) )
            {
                return ((PictureBox)arr[2]);
            }
            else if ((m.shape == n.shape) && (n.shape == o.shape) )
            {
                return ((PictureBox)arr[2]);
            }
            else if ((m.size == n.size) && (n.size == o.size) )
            {
                return ((PictureBox)arr[2]);
            }
            else if ((m.hole == n.hole) && (n.hole == o.hole) )
            {
                return ((PictureBox)arr[2]);
            }

            else return null;
        }
        private void put_the_piece(PictureBox place, PictureBox seat)
        {
            place.Image = seat.Image;
            place.Tag = seat.Tag;
            place.SizeMode = PictureBoxSizeMode.AutoSize;
            if (place.Height == 55)
            {
                place.Top -= 20;
            }
            if (place.Height == 40)
            {
                place.Top -= 7;
            }
            place.SendToBack();
            place.Enabled = false;
            arrboard.Remove(place);
            seat.Image = Properties.Resources.cerceau2;
            //this.Refresh();
            
        }
        public static void set_static_variables(string n1, int countss1, int countss2, int rounds_count, string first_move, int min, int sec,Form f1,Form f2,int v,string l, int s_count)
        {
            player = n1;
            counts1 = countss1;
            counts2 = countss2;
            Round_count = rounds_count;
            First_Move = first_move;
            minutes = min;
            seconds = sec;
            form1 = f1;//playername
            form2 = f2;//main menu
            volume = v;
            lang = l;
            count_sound = s_count;
           
        }
        private void Disable_Buttons()
        {
            foreach (Control con in this.Controls) con.Enabled = false;
        }

        private void check_For_Winner()
        {
            for (int i = 0; i < 1000; i++)
            {
                Application.DoEvents();
            }
            ArrayList red = new ArrayList(4);
            figure m, n, o, p;
            int l = 0;
            while ((l < 4) && (!there_is_a_winner))
            {
                int c = 0;
                while (c < 4)
                {
                    if (!board[l, c].Enabled) c++;
                    else
                    {
                        l++;
                        break;
                    }
                }
                if (c == 4)
                {
                    m = (figure)(board[l, 0].Tag);
                    n = (figure)(board[l, 1].Tag);
                    o = (figure)(board[l, 2].Tag);
                    p = (figure)(board[l, 3].Tag);
                    if ((m.color == n.color) && (n.color == o.color) && (o.color == p.color))
                    {
                        there_is_a_winner = true;
                       
                    }
                    else if ((m.shape == n.shape) && (n.shape == o.shape) && (o.shape == p.shape))
                    {
                        there_is_a_winner = true;
                    }
                    else if ((m.size == n.size) && (n.size == o.size) && (o.size == p.size))
                    {
                        there_is_a_winner = true;
                    }
                    else if ((m.hole == n.hole) && (n.hole == o.hole) && (o.hole == p.hole))
                    {
                        there_is_a_winner = true;
                    }
                    else
                    {
                        there_is_a_winner = false;
                        l++;
                    }
                }
            }
            int c1 = 0;
            while ((c1 < 4) && (!there_is_a_winner))
            {
                int l1 = 0;
                while (l1 < 4)
                {
                    if (!board[l1, c1].Enabled) l1++;
                    else
                    {
                        c1++;
                        break;
                    }
                }
                if (l1 == 4)
                {
                    m = (figure)(board[0, c1].Tag);
                    n = (figure)(board[1, c1].Tag);
                    o = (figure)(board[2, c1].Tag);
                    p = (figure)(board[3, c1].Tag);
                    if ((m.color == n.color) && (n.color == o.color) && (o.color == p.color))
                    {
                        there_is_a_winner = true;
                    }
                    else if ((m.shape == n.shape) && (n.shape == o.shape) && (o.shape == p.shape))
                    {
                        there_is_a_winner = true;
                    }
                    else if ((m.size == n.size) && (n.size == o.size) && (o.size == p.size))
                    {
                        there_is_a_winner = true;
                    }
                    else if ((m.hole == n.hole) && (n.hole == o.hole) && (o.hole == p.hole))
                    {
                        there_is_a_winner = true;
                    }
                    else
                    {
                        there_is_a_winner = false;
                        c1++;
                    }
                }
            }

            if ((!b0.Enabled) && (!b5.Enabled) && (!b10.Enabled) && (!b15.Enabled))
            {
                figure a1 = (figure)board[0, 0].Tag;
                figure a6 = (figure)board[1, 1].Tag;
                figure a11 = (figure)board[2, 2].Tag;
                figure a16 = (figure)board[3, 3].Tag;
                if ((a1.color == a6.color) && (a6.color == a11.color) && (a11.color == a16.color))
                    there_is_a_winner = true;
                if ((a1.shape == a6.shape) && (a6.shape == a11.shape) && (a11.shape == a16.shape))
                    there_is_a_winner = true;
                if ((a1.size == a6.size) && (a6.size == a11.size) && (a11.size == a16.size))
                    there_is_a_winner = true;
                if ((a1.hole == a6.hole) && (a6.hole == a11.hole) && (a11.hole == a16.hole))
                    there_is_a_winner = true;
            }

            if ((!b3.Enabled) && (!b6.Enabled) && (!b9.Enabled) && (!b12.Enabled))
            {
                figure a4 = (figure)board[0, 3].Tag;
                figure a7 = (figure)board[1, 2].Tag;
                figure a10 = (figure)board[2, 1].Tag;
                figure a13 = (figure)board[3, 0].Tag;
                if ((a4.color == a7.color) && (a7.color == a10.color) && (a10.color == a13.color))
                    there_is_a_winner = true;
                if ((a4.shape == a7.shape) && (a7.shape == a10.shape) && (a10.shape == a13.shape))
                    there_is_a_winner = true;
                if ((a4.size == a7.size) && (a7.size == a10.size) && (a10.size == a13.size))
                    there_is_a_winner = true;
                if ((a4.hole == a7.hole) && (a7.hole == a10.hole) && (a10.hole == a13.hole))
                    there_is_a_winner = true;
            }


            if (there_is_a_winner)
            {
                Disable_Buttons();
                music.controls.stop();
                cancel.Enabled = true;
                restart.Enabled = true;
                label3.Visible = true;
                label4.Visible = true;
                Round_count += 1;
                label2.ForeColor = Color.Red;
                yes.Visible = true;
                no.Visible = true;
                yes.Enabled = true;
                no.Enabled = true;
                label2.Enabled = true;
                if (lang == "english")
                {
                    label2.Text = "Do you want to play again?";
                    yes.Text = "YES";
                    no.Text = "NO";
                }

                else if (lang == "francais")
                {
                    label2.Text = "Veux-tu jouer a nouveau?";
                    yes.Text = "OUI";
                    no.Text = "NON";
                }
                label4.Enabled = true;
                label3.Enabled = true;
                if (!turn1)
                {
                    counts1 += 1;
                    count1.Text = counts1.ToString();
                   
                    if (lang == "english")
                    {
                        label3.Text = "WINNER!!!";
                        label4.Text = "LOSER";
                    }

                    else if (lang == "francais")
                    {
                        label3.Text = "GAGNANT!!!";
                        label4.Text = "PERDANT";
                    }
                   

                }
                if (turn1)
                {
                    counts2 += 1;
                    count2.Text = counts2.ToString();

                    if (lang == "english")
                    {
                        label3.Text = "LOSER";
                        label4.Text = "WINNER!!!";
                    }

                    else if (lang == "francais")
                    {
                        label3.Text = "PERDANT";
                        label4.Text = "GAGNANT!!!";
                    }

                }

            }

        }
      
        private void AGAINST_CPU_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void p0_Click(object sender, EventArgs e)
        {
            if (turn1)
            {
                pieces_sound.URL = "piece_sound.wav";
                pieces_sound.controls.play();
                pieces_sound.settings.volume = volume;
                Random random = new Random();
                ArrayList arrstones = new ArrayList();
                ArrayList arrstones1 = new ArrayList();
                ArrayList arrstones2 = new ArrayList();
                ArrayList best_piece1 = new ArrayList();
                ArrayList best_piece2 = new ArrayList();
                ArrayList best_piece = new ArrayList();
                PictureBox place;
                figure m;
                PictureBox p = (PictureBox)sender;
                m = (figure)p.Tag;
                int x = m.index;
              
                //the player choose a piece for cpu
                this.Controls.Remove(p);
                arrpieces.Remove(p);
                seat.Image = k[x].Image;
                seat.SizeMode = PictureBoxSizeMode.AutoSize;
                seat.Tag = p.Tag;
                if (lang == "english")
                {
                    label2.Text = "Here's a piece for you to put on the board!";

                }
                else if (lang == "francais")
                {
                    label2.Text = "Voici la pièce a mettre sur le plateau!";

                }
                //  this.Refresh();
                //cpu put the piece on the board
                place = look_for_win_lines(seat);
                if (place != null)
                {
                    put_the_piece(place, seat);
                }
                else if (place == null)
                {
                    place = look_for_win_colomns(seat);
                    if (place != null)
                    {
                        put_the_piece(place, seat);
                    }

                    //hon na2sa l diagonal ok!!!
                    else if (place == null)
                    {
                        place = BUILD_WIN_lines(seat);
                        if (place != null)
                        {
                            put_the_piece(place, seat);
                        }


                        else if (place == null)
                        {
                            place = BUILD_WIN_colomns(seat);
                            if (place != null)
                            {
                                put_the_piece(place, seat);
                            }
                            else if (place == null)
                            {
                                int i = random.Next(0, arrboard.Count);
                                place = (PictureBox)arrboard[i];
                                place.Image = seat.Image;
                                place.Tag = seat.Tag;
                                place.SizeMode = PictureBoxSizeMode.AutoSize;
                                if (place.Height == 55)
                                {
                                    place.Top -= 20;
                                }
                                if (place.Height == 40)
                                {
                                    place.Top -= 7;
                                }
                                place.SendToBack();
                                place.Enabled = false;
                                arrboard.Remove(place);
                                seat.Image = Properties.Resources.cerceau2;
                                this.Refresh();
                            }
                        }
                    }
                  
                    
                }
                check_For_Winner();

                //choose a piece for the player
                if (!there_is_a_winner)
                {
                    arrstones1 = Three_Pieces_Lines();
                    arrstones2 = Three_Pieces_colomns();
                    ArrayList pieces_allowed = new ArrayList();
                    for (int ii = 0; ii < arrpieces.Count; ii++)
                    {
                        if ((arrstones1.IndexOf(arrpieces[ii]) < 0) && (arrstones2.IndexOf(arrpieces[ii]) < 0))
                            pieces_allowed.Add(arrpieces[ii]);
                    }

                    if ((pieces_allowed.Count != 0) && (pieces_allowed.Count != arrpieces.Count))
                    {
                        best_piece1 = Two_Pieces_Lines();
                        best_piece2 = Two_Pieces_colomns();
                        //diagonal
                        for (int iii = 0; iii < pieces_allowed.Count; iii++)
                        {//erreur
                            if ((best_piece1.IndexOf(pieces_allowed[iii]) > 0) || (best_piece2.IndexOf(pieces_allowed[iii]) > 0))
                                best_piece.Add(pieces_allowed[iii]);
                        }
                        if (best_piece.Count != 0)
                        {
                            int xx = random.Next(0, best_piece.Count);
                            m = (figure)(((PictureBox)best_piece[xx]).Tag);
                            x = m.index;
                            this.Controls.Remove(pic[x]);
                            arrpieces.Remove(pic[x]);

                            seat.Image = k[x].Image;
                            seat.SizeMode = PictureBoxSizeMode.AutoSize;
                            seat.Tag = ((PictureBox)best_piece[xx]).Tag;
                            this.Refresh();
                        }
                        else if ((best_piece.Count == 0) && (pieces_allowed.Count != 0))
                        {
                            int xxx = random.Next(0, pieces_allowed.Count);
                            //hon badda tzbit l index!!!!
                            m = (figure)(((PictureBox)pieces_allowed[xxx]).Tag);
                            x = m.index;
                            this.Controls.Remove(pic[x]);
                            arrpieces.Remove(pic[x]);
                            seat.Image = k[x].Image;
                            seat.SizeMode = PictureBoxSizeMode.AutoSize;
                            seat.Tag = (pic[x]).Tag;
                            this.Refresh();
                        }
                    }
                    else if (pieces_allowed.Count == 0)
                    {
                        int xxxx = random.Next(0, arrpieces.Count);
                        m = (figure)(((PictureBox)arrpieces[xxxx]).Tag);
                        x = m.index;
                        this.Controls.Remove(pic[x]);
                        arrpieces.Remove(pic[x]);
                        seat.Image = k[x].Image;
                        seat.SizeMode = PictureBoxSizeMode.AutoSize;
                        seat.Tag = (pic[x]).Tag;
                        this.Refresh();
                    }
                    else if (pieces_allowed.Count == arrpieces.Count)//hon l shghl
                    {
                        //essa l diagonal
                        ArrayList two_pieces_liness = new ArrayList();
                        ArrayList two_pieces_colomnss = new ArrayList();
                        two_pieces_liness = Two_Pieces_Lines();
                        two_pieces_colomnss = Two_Pieces_colomns();
                        ArrayList two_pieces = new ArrayList();
                        for (int jj = 0; jj < two_pieces_liness.Count; jj++)
                        {
                            if (two_pieces_colomnss.IndexOf(two_pieces_liness[jj]) < 0)
                                two_pieces.Add(two_pieces_liness[jj]);
                        }
                        two_pieces.AddRange(two_pieces_colomnss);
                        if (two_pieces.Count != 0)
                        {
                            int xxxx = random.Next(0, two_pieces.Count);
                            m = (figure)(((PictureBox)two_pieces[xxxx]).Tag);
                            x = m.index;
                            this.Controls.Remove(pic[x]);
                            arrpieces.Remove(pic[x]);
                            seat.Image = k[x].Image;
                            seat.SizeMode = PictureBoxSizeMode.AutoSize;
                            seat.Tag = (pic[x]).Tag;
                            this.Refresh();
                            //hon na2sna l diagonal
                        }
                        else
                        {
                            int xxxxx = random.Next(0, pieces_allowed.Count);
                            m = (figure)(((PictureBox)pieces_allowed[xxxxx]).Tag);
                            x = m.index;
                            this.Controls.Remove(pic[x]);
                            arrpieces.Remove(pic[x]);
                            seat.Image = k[x].Image;
                            seat.SizeMode = PictureBoxSizeMode.AutoSize;
                            seat.Tag = ((PictureBox)pieces_allowed[xxxxx]).Tag;
                            this.Refresh();
                        }

                    }
                    turn1 = !turn1;
                    arrstones1.Clear();
                    arrstones2.Clear();
                    pieces_allowed.Clear();
                    best_piece.Clear();
                    best_piece1.Clear();
                    best_piece2.Clear();
                    arrstones.Clear();
                }
            }

          
        }
    

        private void invisible()
        {
            foreach (Control c in this.Controls)
            {
                try
                {
                    PictureBox p = (PictureBox)c;

                    p.Visible = false;
                }
                catch { };
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (there_is_a_winner)
            {
                if (yes.Checked)
                {
                    timer1.Stop();
                    AGAINST_CPU aGAINST_CPU = new AGAINST_CPU();

                    this.Hide();
                    aGAINST_CPU.ShowDialog();
                    
                }
                else if (no.Checked)
                {
                    timer1.Stop();
                    RESULT_CPUcs rESULT_CP = new RESULT_CPUcs(player, counts1, Round_count - 1,form2,lang,volume);

                    this.Hide();
                    rESULT_CP.ShowDialog();
                   
                }
            }
        }

        private void p0_MouseHover(object sender, EventArgs e)
        {
            PictureBox p = new PictureBox();
            if (turn1)
            {
                
                p.Cursor = Cursors.Hand;
            }
        }
        private void p0_MouseLeave(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            if (turn1)
            {
                p.Cursor = Cursors.Hand;
            }

        }
        private void b0_MouseHover(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            if (!turn1)
            {
                b.Cursor = Cursors.Hand;
                b.Image = Properties.Resources.selection_gray;
            }
        }
        private void b0_MouseLeave(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            if (!turn1)
            {
                if (b.Enabled)
                {
                    b.Cursor = Cursors.Hand;
                    b.Image = Properties.Resources.cerceau2;
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            music.controls.stop();
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            Round_count = 1;
            counts1 = 0;
            counts2 = 0;
            AGAINST_CPU gAINST_CPU = new AGAINST_CPU();
            this.Close();
            this.Hide();
            gAINST_CPU.ShowDialog();
        }
        private void ok_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackgroundImage = Properties.Resources.Changed_b1;
            b.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void sound_Click(object sender, EventArgs e)
        {
            count_sound += 1;
            if (count_sound % 2 == 1)
            {
                sound.Image = Properties.Resources.sound1_on;
                music.settings.volume = volume;
            }

            else if (count_sound % 2 == 0)
            {
                music.settings.volume = 0;
                sound.Image = Properties.Resources.sound2_off;
            }
        }

        private void ok_MouseLeave(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            b.BackgroundImage = Properties.Resources.ok_b1;
            b.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void AGAINST_CPU_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            music.controls.stop();
            form2.Show();
            this.Hide();
        }
    
        private void ok_Click(object sender, EventArgs e)
        {
            sound_button.URL = "button_sound.wav";
            sound_button.controls.play();
            sound_button.settings.volume = volume;
            music.controls.stop();
            this.Hide();
            form2.Show();
            form1.Show();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            if (!turn1)
            {
                sound_button.URL = "button_sound.wav";
                sound_button.controls.play();
                sound_button.settings.volume = volume;
                if (seat.Image != null)
                {
                    b.Image = seat.Image;
                    b.Tag = seat.Tag;
                    b.SizeMode = PictureBoxSizeMode.AutoSize;
                    if (b.Height == 55)
                    {
                        b.Top -= 20;
                    }
                    if (b.Height == 40)
                    {
                        b.Top -= 7;
                    }
                    b.SendToBack();
                    b.Enabled = false;
                    arrboard.Remove(b);
                    seat.Image = Properties.Resources.cerceau2;
                    this.Refresh();

                }
                if (lang == "english")
                {
                    label2.Text = "Choose a piece for me please!";
                }
                else if (lang == "francais")
                {
                    label2.Text = "Choisir une pièce pour moi please!";
                }
                check_For_Winner();
             
                turn1 = !turn1;
                
            }
        }
        private void visible()
        {
            foreach (Control c in this.Controls)
            {

                try
                {
                    PictureBox p = (PictureBox)c;
                    p.Enabled = true;
                    p.Visible = true;
                }
                catch { };
            }
        }
        private void timer1_load_Tick(object sender, EventArgs e)
        {
            t++;
            if (lang == "english")
            {
                txt = "ROUND" + Round_count.ToString() + ".";
                {
                    if (t < txt.Length + 1)
                    {
                        label1.Text += txt[t].ToString();
                    }
                }
            }
            else
            {
                txt = "TOUR" + Round_count.ToString() + ".";
                {
                    if (t < txt.Length + 1)
                    {
                        label1.Text += txt[t].ToString();
                    }
                }
            }
            if (label1.Text.Length == txt.Length)
            {
                music.URL = "Quarto_Music.wav";
                music.controls.play();
                music.settings.volume = volume;
                if (volume == 0)
                {
                    sound.Image = Properties.Resources.sound2_off;
                }
                else
                {
                    sound.Image = Properties.Resources.sound1_on;
                }
                timer1_load.Stop();

                if (lang == "english")
                {
                    cancel.Text = "Cancel";
                    restart.Text = "Restart";
                }
                else if (lang == "francais")
                {
                    cancel.Text = "Annuler";
                    restart.Text = "Repartir";
                }
                this.Controls.Remove(label1);
                this.BackgroundImage = null;
                this.BackgroundImage = Properties.Resources.backgd;

                visible();
                player_nm1.Visible = true;
                player_nm2.Visible = true;
                count1.Visible = true;
                count2.Visible = true;
                restart.Visible = true;
                cancel.Visible = true;

                label2.Visible = true;

                player_nm1.Text = player;
                

                if (First_Move == "Computer")
                {
                    ArrayList arrstones = new ArrayList();
                    ArrayList arrstones1 = new ArrayList();
                    ArrayList arrstones2 = new ArrayList();
                    ArrayList best_piece1 = new ArrayList();
                    ArrayList best_piece2 = new ArrayList();
                    ArrayList best_piece = new ArrayList();
                    Random random = new Random();
                    figure m;
                    int x;
                
                    turn1 = false;
                    if (lang == "english")
                    label2.Text = "Here's a piece for you to put on the board!";
                    if (lang == "francais")
                        label2.Text = "Voici la pièce a mettre sur le plateau!";
                    arrstones1 = Three_Pieces_Lines();
                    arrstones2 = Three_Pieces_colomns();
                    ArrayList pieces_allowed = new ArrayList();
                    for (int ii = 0; ii < arrpieces.Count; ii++)
                    {
                        if ((arrstones1.IndexOf(arrpieces[ii]) < 0) && (arrstones2.IndexOf(arrpieces[ii]) < 0))
                            pieces_allowed.Add(arrpieces[ii]);
                    }

                    if ((pieces_allowed.Count != 0) && (pieces_allowed.Count != arrpieces.Count))
                    {
                        best_piece1 = Two_Pieces_Lines();
                        best_piece2 = Two_Pieces_colomns();
                        //diagonal
                        for (int iii = 0; iii < pieces_allowed.Count; iii++)
                        {//erreur
                            if ((best_piece1.IndexOf(pieces_allowed[iii]) > 0) || (best_piece2.IndexOf(pieces_allowed[iii]) > 0))
                                best_piece.Add(pieces_allowed[iii]);
                        }
                        if (best_piece.Count != 0)
                        {
                            int xx = random.Next(0, best_piece.Count);
                            m = (figure)(((PictureBox)best_piece[xx]).Tag);
                            x = m.index;
                            this.Controls.Remove(pic[x]);
                            arrpieces.Remove(pic[x]);

                            seat.Image = k[x].Image;
                            seat.SizeMode = PictureBoxSizeMode.AutoSize;
                            seat.Tag = ((PictureBox)best_piece[xx]).Tag;
                            this.Refresh();
                        }
                        else if ((best_piece.Count == 0) && (pieces_allowed.Count != 0))
                        {
                            int xxx = random.Next(0, pieces_allowed.Count);
                            //hon badda tzbit l index!!!!
                            m = (figure)(((PictureBox)pieces_allowed[xxx]).Tag);
                            x = m.index;
                            this.Controls.Remove(pic[x]);
                            arrpieces.Remove(pic[x]);
                            seat.Image = k[x].Image;
                            seat.SizeMode = PictureBoxSizeMode.AutoSize;
                            seat.Tag = (pic[x]).Tag;
                            this.Refresh();
                        }
                    }
                    else if (pieces_allowed.Count == 0)
                    {
                        int xxxx = random.Next(0, arrpieces.Count);
                        m = (figure)(((PictureBox)arrpieces[xxxx]).Tag);
                        x = m.index;
                        this.Controls.Remove(pic[x]);
                        arrpieces.Remove(pic[x]);
                        seat.Image = k[x].Image;
                        seat.SizeMode = PictureBoxSizeMode.AutoSize;
                        seat.Tag = (pic[x]).Tag;
                        this.Refresh();
                    }
                    else if (pieces_allowed.Count == arrpieces.Count)//hon l shghl
                    {
                        //essa l diagonal
                        ArrayList two_pieces_liness = new ArrayList();
                        ArrayList two_pieces_colomnss = new ArrayList();
                        two_pieces_liness = Two_Pieces_Lines();
                        two_pieces_colomnss = Two_Pieces_colomns();
                        ArrayList two_pieces = new ArrayList();
                        for (int jj = 0; jj < two_pieces_liness.Count; jj++)
                        {
                            if (two_pieces_colomnss.IndexOf(two_pieces_liness[jj]) < 0)
                                two_pieces.Add(two_pieces_liness[jj]);
                        }
                        two_pieces.AddRange(two_pieces_colomnss);
                        if (two_pieces.Count != 0)
                        {
                            int xxxx = random.Next(0, two_pieces.Count);
                            m = (figure)(((PictureBox)two_pieces[xxxx]).Tag);
                            x = m.index;
                            this.Controls.Remove(pic[x]);
                            arrpieces.Remove(pic[x]);
                            seat.Image = k[x].Image;
                            seat.SizeMode = PictureBoxSizeMode.AutoSize;
                            seat.Tag = (pic[x]).Tag;
                            this.Refresh();
                            //hon na2sna l diagonal
                        }
                        else
                        {
                            int xxxxx = random.Next(0, pieces_allowed.Count);
                            m = (figure)(((PictureBox)pieces_allowed[xxxxx]).Tag);
                            x = m.index;
                            this.Controls.Remove(pic[x]);
                            arrpieces.Remove(pic[x]);
                            seat.Image = k[x].Image;
                            seat.SizeMode = PictureBoxSizeMode.AutoSize;
                            seat.Tag = ((PictureBox)pieces_allowed[xxxxx]).Tag;
                            this.Refresh();
                        }

                    }
                   
                    arrstones1.Clear();
                    arrstones2.Clear();
                    pieces_allowed.Clear();
                    best_piece.Clear();
                    best_piece1.Clear();
                    best_piece2.Clear();
                    arrstones.Clear();

                }
                else if (First_Move == "Player")
                {
                    turn1 = true;
                    if (lang == "english")
                        label2.Text = "choose a piece for me please!";
                    if (lang == "francais")
                        label2.Text = "Choisir une pièce pour moi please!";
                   
                }
                else if (First_Move == "Take turns")
                {
                    if (Round_count % 2 == 1)
                    {
                        turn1 = true;
                        if (lang == "english")
                            label2.Text = "choose a piece for me please!";
                        if (lang == "francais")
                            label2.Text = "Choisir une pièce pour moi please!";
                    }
                    else
                    {
                        ArrayList arrstones = new ArrayList();
                        ArrayList arrstones1 = new ArrayList();
                        ArrayList arrstones2 = new ArrayList();
                        ArrayList best_piece1 = new ArrayList();
                        ArrayList best_piece2 = new ArrayList();
                        ArrayList best_piece = new ArrayList();
                        Random random = new Random();
                        figure m;
                        int x;

                        turn1 = false;
                        if (lang == "english")
                            label2.Text = "Here's a piece for you to put on the board!";
                        if (lang == "francais")
                            label2.Text = "Voici la pièce a mettre sur le plateau!";
                        arrstones1 = Three_Pieces_Lines();
                        arrstones2 = Three_Pieces_colomns();
                        ArrayList pieces_allowed = new ArrayList();
                        for (int ii = 0; ii < arrpieces.Count; ii++)
                        {
                            if ((arrstones1.IndexOf(arrpieces[ii]) < 0) && (arrstones2.IndexOf(arrpieces[ii]) < 0))
                                pieces_allowed.Add(arrpieces[ii]);
                        }

                        if ((pieces_allowed.Count != 0) && (pieces_allowed.Count != arrpieces.Count))
                        {
                            best_piece1 = Two_Pieces_Lines();
                            best_piece2 = Two_Pieces_colomns();
                            //diagonal
                            for (int iii = 0; iii < pieces_allowed.Count; iii++)
                            {//erreur
                                if ((best_piece1.IndexOf(pieces_allowed[iii]) > 0) || (best_piece2.IndexOf(pieces_allowed[iii]) > 0))
                                    best_piece.Add(pieces_allowed[iii]);
                            }
                            if (best_piece.Count != 0)
                            {
                                int xx = random.Next(0, best_piece.Count);
                                m = (figure)(((PictureBox)best_piece[xx]).Tag);
                                x = m.index;
                                this.Controls.Remove(pic[x]);
                                arrpieces.Remove(pic[x]);

                                seat.Image = k[x].Image;
                                seat.SizeMode = PictureBoxSizeMode.AutoSize;
                                seat.Tag = ((PictureBox)best_piece[xx]).Tag;
                                this.Refresh();
                            }
                            else if ((best_piece.Count == 0) && (pieces_allowed.Count != 0))
                            {
                                int xxx = random.Next(0, pieces_allowed.Count);
                                //hon badda tzbit l index!!!!
                                m = (figure)(((PictureBox)pieces_allowed[xxx]).Tag);
                                x = m.index;
                                this.Controls.Remove(pic[x]);
                                arrpieces.Remove(pic[x]);
                                seat.Image = k[x].Image;
                                seat.SizeMode = PictureBoxSizeMode.AutoSize;
                                seat.Tag = (pic[x]).Tag;
                                this.Refresh();
                            }
                        }
                        else if (pieces_allowed.Count == 0)
                        {
                            int xxxx = random.Next(0, arrpieces.Count);
                            m = (figure)(((PictureBox)arrpieces[xxxx]).Tag);
                            x = m.index;
                            this.Controls.Remove(pic[x]);
                            arrpieces.Remove(pic[x]);
                            seat.Image = k[x].Image;
                            seat.SizeMode = PictureBoxSizeMode.AutoSize;
                            seat.Tag = (pic[x]).Tag;
                            this.Refresh();
                        }
                        else if (pieces_allowed.Count == arrpieces.Count)//hon l shghl
                        {
                            //essa l diagonal
                            ArrayList two_pieces_liness = new ArrayList();
                            ArrayList two_pieces_colomnss = new ArrayList();
                            two_pieces_liness = Two_Pieces_Lines();
                            two_pieces_colomnss = Two_Pieces_colomns();
                            ArrayList two_pieces = new ArrayList();
                            for (int jj = 0; jj < two_pieces_liness.Count; jj++)
                            {
                                if (two_pieces_colomnss.IndexOf(two_pieces_liness[jj]) < 0)
                                    two_pieces.Add(two_pieces_liness[jj]);
                            }
                            two_pieces.AddRange(two_pieces_colomnss);
                            if (two_pieces.Count != 0)
                            {
                                int xxxx = random.Next(0, two_pieces.Count);
                                m = (figure)(((PictureBox)two_pieces[xxxx]).Tag);
                                x = m.index;
                                this.Controls.Remove(pic[x]);
                                arrpieces.Remove(pic[x]);
                                seat.Image = k[x].Image;
                                seat.SizeMode = PictureBoxSizeMode.AutoSize;
                                seat.Tag = (pic[x]).Tag;
                                this.Refresh();
                                //hon na2sna l diagonal
                            }
                            else
                            {
                                int xxxxx = random.Next(0, pieces_allowed.Count);
                                m = (figure)(((PictureBox)pieces_allowed[xxxxx]).Tag);
                                x = m.index;
                                this.Controls.Remove(pic[x]);
                                arrpieces.Remove(pic[x]);
                                seat.Image = k[x].Image;
                                seat.SizeMode = PictureBoxSizeMode.AutoSize;
                                seat.Tag = ((PictureBox)pieces_allowed[xxxxx]).Tag;
                                this.Refresh();
                            }

                        }

                        arrstones1.Clear();
                        arrstones2.Clear();
                        pieces_allowed.Clear();
                        best_piece.Clear();
                        best_piece1.Clear();
                        best_piece2.Clear();
                        arrstones.Clear();

                    }
                }

               
                this.Refresh();
            }

        }
        
        struct figure
        {
            public string color, shape, size, hole;
            public int index;
        }
        private void AGAINST_CPU_Load(object sender, EventArgs e)
        {
            timer1.Start();
          
            cancel.Visible = false;
            restart.Visible = false;

            label3.Visible = false;
            label4.Visible = false;

            yes.Checked = false;
            no.Checked = false;
            yes.Visible = false;
            no.Visible = false;
          
            count1.Text = counts1.ToString();
            count2.Text = counts2.ToString();
            label1.Text = "";
            timer1_load.Enabled = true;
            timer1_load.Start();
            if (timer1_load.Enabled)
            {
                this.BackgroundImage = Properties.Resources.fatoumaaaaaaaaaaaaaaa;
                label1.Enabled = true;
                invisible();
                player_nm1.Visible = false;
                player_nm2.Visible = false;
                count1.Visible = false;
                count2.Visible = false;
                label2.Visible = false;
               
            }
            //brown pieces
            figure piece0;
            piece0.color = "brown"; piece0.shape = "circle"; piece0.size = "short"; piece0.hole = "no"; piece0.index = 0;
            figure piece1;
            piece1.color = "brown"; piece1.shape = "circle"; piece1.size = "short"; piece1.hole = "yes"; piece1.index = 1;
            figure piece2;
            piece2.color = "brown"; piece2.shape = "circle"; piece2.size = "tall"; piece2.hole = "no"; piece2.index = 2;
            figure piece3;
            piece3.color = "brown"; piece3.shape = "circle"; piece3.size = "tall"; piece3.hole = "yes"; piece3.index = 3;
            figure piece4;
            piece4.color = "brown"; piece4.shape = "carre"; piece4.size = "short"; piece4.hole = "no"; piece4.index = 4;
            figure piece5;
            piece5.color = "brown"; piece5.shape = "carre"; piece5.size = "short"; piece5.hole = "yes"; piece5.index = 5;
            figure piece6;
            piece6.color = "brown"; piece6.shape = "carre"; piece6.size = "tall"; piece6.hole = "no"; piece6.index = 6;
            figure piece7;
            piece7.color = "brown"; piece7.shape = "carre"; piece7.size = "tall"; piece7.hole = "yes"; piece7.index = 7;

            //beige pieces
            figure piece8;
            piece8.color = "beige"; piece8.shape = "circle"; piece8.size = "short"; piece8.hole = "no"; piece8.index = 8;
            figure piece9;
            piece9.color = "beige"; piece9.shape = "circle"; piece9.size = "short"; piece9.hole = "yes"; piece9.index = 9;
            figure piece10;
            piece10.color = "beige"; piece10.shape = "circle"; piece10.size = "tall"; piece10.hole = "no"; piece10.index = 10;
            figure piece11;
            piece11.color = "beige"; piece11.shape = "circle"; piece11.size = "tall"; piece11.hole = "yes"; piece11.index = 11;
            figure piece12;
            piece12.color = "beige"; piece12.shape = "carre"; piece12.size = "short"; piece12.hole = "no"; piece12.index = 12;
            figure piece13;
            piece13.color = "beige"; piece13.shape = "carre"; piece13.size = "short"; piece13.hole = "yes"; piece13.index = 13;
            figure piece14;
            piece14.color = "beige"; piece14.shape = "carre"; piece14.size = "tall"; piece14.hole = "no"; piece14.index = 14;
            figure piece15;
            piece15.color = "beige"; piece15.shape = "carre"; piece15.size = "tall"; piece15.hole = "yes"; piece15.index = 15;

            board = new PictureBox[4, 4];
            board[0, 0] = b0;
            board[0, 1] = b1;
            board[0, 2] = b2;
            board[0, 3] = b3;
            board[1, 0] = b4;
            board[1, 1] = b5;
            board[1, 2] = b6;
            board[1, 3] = b7;
            board[2, 0] = b8;
            board[2, 1] = b9;
            board[2, 2] = b10;
            board[2, 3] = b11;
            board[3, 0] = b12;
            board[3, 1] = b13;
            board[3, 2] = b14;
            board[3, 3] = b15;

            arrpieces.Add(p0); arrpieces.Add(p1); arrpieces.Add(p2); arrpieces.Add(p3);
            arrpieces.Add(p4); arrpieces.Add(p5); arrpieces.Add(p6); arrpieces.Add(p7);
            arrpieces.Add(p8); arrpieces.Add(p9); arrpieces.Add(p10); arrpieces.Add(p11);
            arrpieces.Add(p12); arrpieces.Add(p13); arrpieces.Add(p14); arrpieces.Add(p15);

            arrboard.Add(b0); arrboard.Add(b1); arrboard.Add(b2); arrboard.Add(b3); arrboard.Add(b4);
            arrboard.Add(b5); arrboard.Add(b6); arrboard.Add(b7); arrboard.Add(b8); arrboard.Add(b9);
            arrboard.Add(b10); arrboard.Add(b11); arrboard.Add(b12); arrboard.Add(b13); arrboard.Add(b14);
            arrboard.Add(b15);


            p0.Tag = piece0;
            p1.Tag = piece1;
            p2.Tag = piece2;
            p3.Tag = piece3;
            p4.Tag = piece4;
            p5.Tag = piece5;
            p6.Tag = piece6;
            p7.Tag = piece7;
            p8.Tag = piece8;
            p9.Tag = piece9;
            p10.Tag = piece10;
            p11.Tag = piece11;
            p12.Tag = piece12;
            p13.Tag = piece13;
            p14.Tag = piece14;
            p15.Tag = piece15;

            pic = new PictureBox[16];
            pic[0] = p0; pic[1] = p1; pic[2] = p2; pic[3] = p3; pic[4] = p4; pic[5] = p5; pic[6] = p6; pic[7] = p7;
            pic[8] = p8; pic[9] = p9; pic[10] = p10; pic[11] = p11; pic[12] = p12; pic[13] = p13; pic[14] = p14; pic[15] = p15;

            k = new PictureBox[16];
            k[0] = k0; k[1] = k1; k[2] = k2; k[3] = k3; k[4] = k4; k[5] = k5; k[6] = k6; k[7] = k7;
            k[8] = k8; k[9] = k9; k[10] = k10; k[11] = k11; k[12] = k12; k[13] = k13; k[14] = k14; k[15] = k15;

        }

    }
}
