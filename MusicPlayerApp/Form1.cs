using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        //Create global variables of String type Array to save the titles of the songs and to save path to them
        String[] paths, files;

        private void BtnSelectSongs_Click(object sender, EventArgs e)
        {
            //Code to select songs
            OpenFileDialog ofd = new OpenFileDialog();

            //Code to select multiple songs
            ofd.Multiselect = true;

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //Save the file names in array
                paths = ofd.FileNames; //Save the path to that files in array

                //Display the song names in listBox
                for (int i= 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);//Display songs in listbox
                }
            }
        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //write a code to play a music
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //code to close App
            this.Close();
        }
    }
}
