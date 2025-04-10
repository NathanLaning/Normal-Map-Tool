using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Normal_Map_Converter
{
    public partial class Form1 : Form
    {
        Bitmap loadedImage;
        Bitmap newImage;
        MAP NORMAL;
        int red, green, blue;
        int resolution, progress = 0;
        List<TrackBar> TrackBarItems;
        List<TextBox> TextBoxItems;
        List<Button> ButtonItems;
        double loadingBarIncrement;
        public Form1()
        {
            InitializeComponent();
            TextBoxItems = new List<TextBox>() { GREEN_TextBox, RED_TextBox, BLUE_TextBox, RESOLUTION_TextBox, SAMPLESIZE_TextBox };
            TrackBarItems = new List<TrackBar>() { GREEN_Slider, RED_Slider, BLUE_Slider, RESOLUTION_Slider, SAMPLESIZE_Slider };
            ButtonItems = new List<Button>() { AVERAGE_Button, GENERATE_Button };
            disableALL(TextBoxItems);
            disableALL(TrackBarItems);
            disableALL(ButtonItems);

        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.gif;*.png*;*.tiff*)";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null)
                    {
                        loadedImage = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                        pictureBox2.Image = loadedImage;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        NORMAL = new MAP(loadedImage);
                        newImage = NORMAL.GetBMP();
                        pictureBox1.Image = newImage;
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        //Populating and enabling text fields/bars
                        GENERATE_Button.Enabled = true;
                        enableALL(TextBoxItems);
                        enableALL(TrackBarItems);
                        enableALL(ButtonItems);
                        RED_TextBox.Text = NORMAL.AVE.R.ToString();
                        GREEN_TextBox.Text = NORMAL.AVE.G.ToString();
                        BLUE_TextBox.Text = NORMAL.AVE.B.ToString();
                        SAMPLESIZE_TextBox.Text = ((NORMAL.RANGE - 1) / 2).ToString();
                        RESOLUTION_TextBox.Text = NORMAL.RESOLUTION.ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void initializeLoadingBar(int total)
        {
            loadingBarIncrement = total / 50.0;
        }
        public void incrementLoadingBar()
        {
            progress++;
            if (((CREATEMAP_ProgressBar.Value + 1) * loadingBarIncrement )< progress){
                CREATEMAP_ProgressBar.Increment(1);
        }
        }
        private void disableALL(List<Button> B)
        {
            foreach (Button b in B)
            {
                enabled(b, false);
            }
        }
        private void enableALL(List<Button> B)
        {
            foreach (Button b in B)
            {
                enabled(b, true);
            }
        }
        private void disableALL(List<TrackBar> T)
        {
            foreach( TrackBar t in T){
                enabled(t, false);
            }
        }
        private void disableALL(List<TextBox> T)
        {
            foreach (TextBox t in T)
            {
                enabled(t, false);
            }
        }
        private void enableALL(List<TextBox> T)
        {
            foreach (TextBox t in T)
            {
                enabled(t, true);
            }
        }
        private void enableALL(List<TrackBar> T)
        {
            foreach (TrackBar t in T)
            {
                enabled(t, true);
            }
        }
        private void enabled(TextBox textbox, bool b)
        {
            try
            {
                textbox.Enabled = b;
            }
            catch (NullReferenceException ex)
            {

            }
        }
        private void enabled(Button button, bool b)
        {
            try
            {
                button.Enabled = b;
            }
            catch (NullReferenceException ex)
            {

            }
        }
        private void enabled(TrackBar trackbar,bool b)
        {
            try
            {
                trackbar.Enabled = b;
            } catch (NullReferenceException ex)
            {

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Quit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void SaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.gif;*.png*;*.tiff*)";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                newImage.Save(dialog.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NORMAL.AVE = Color.FromArgb(red, green, blue);
            NORMAL.GetBMP();
            newImage = NORMAL.GetBMP();
            pictureBox1.Image = newImage;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //byte[] b = new byte[] {NORMAL.AVE.A, NORMAL.AVE.R, NORMAL.AVE.G, NORMAL.AVE.B };
            //object a = NORMAL.AVE.R;
            //object b = NORMAL.AVE.G;
            //object c = NORMAL.AVE.B;
            Color c = Color.FromArgb(122, 123, 124);
            object[] o = new object[] { NORMAL.AVE.R, NORMAL.AVE.G, NORMAL.AVE.B };
            AVERAGE.Text = String.Format("{0},{1},{2}", o);
        }

     

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /**
        * color sliders for Average
        **/
        private void red_Scroll(object sender, EventArgs e)
        {
            RED_TextBox.Text = RED_Slider.Value.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int temp = validateInput(RED_TextBox.Text);
            if (temp != -1)
            {
                RED_Slider.Value = temp;
                red = temp;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int temp = validateInput(BLUE_TextBox.Text);
            if (temp != -1)
            {
                BLUE_Slider.Value = temp;
                blue = temp;
            }
        }

        private int validateInput(string s)
        {
            try { 
            int val = int.Parse(s);
            if (val >= 0 && val <= 255)
            {
                return val;
                }else
                {
                    return -1;
                }
            }
            catch(Exception e) {
                return -1;
            }
        }

        private void GREEN_TextBox_TextChanged(object sender, EventArgs e)
        {
            
            int temp = validateInput(GREEN_TextBox.Text);
            if(temp != -1)
            {
                GREEN_Slider.Value =temp;
                green = temp;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NORMAL.findAverage();
            RED_TextBox.Text = NORMAL.AVE.R.ToString();
            GREEN_TextBox.Text = NORMAL.AVE.G.ToString();
            BLUE_TextBox.Text = NORMAL.AVE.B.ToString();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void RESOLUTION_Slider_Scroll(object sender, EventArgs e)
        {
            NORMAL.RESOLUTION = RESOLUTION_Slider.Value;
            RESOLUTION_TextBox.Text = RESOLUTION_Slider.Value.ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            NORMAL.RANGE = (SAMPLESIZE_Slider.Value*2)+1;
            SAMPLESIZE_TextBox.Text = SAMPLESIZE_Slider.Value.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void RESOLUTION_TextBox_TextChanged(object sender, EventArgs e)
        {
            int val = NORMAL.RESOLUTION;
            try
            {
                val = int.Parse(RESOLUTION_TextBox.Text);
                if (val >= 1 && val <= 500)
                {
                    RESOLUTION_Slider.Value = val;
                    NORMAL.RESOLUTION = val;
                    resolution = NORMAL.RESOLUTION;
                }
                else
                {
                    MessageBox.Show("Error: Outside of acceptable bounds, Please enter a number from 1 to 500 ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Incorrect Data Entry, Please enter a number from 1 to 500 " + ex.Message);
            }
        }

        private void SAMPLESIZE_TextBox_TextChanged(object sender, EventArgs e)
        {
            int val = 2;
            try
            {
                val = int.Parse(SAMPLESIZE_TextBox.Text);
                if (val > 0 && val < 11)
                {
                    SAMPLESIZE_Slider.Value = val;
                    NORMAL.RANGE = (val*2)+1;
                }
                else
                {
                    MessageBox.Show("Error: Outside of acceptable bounds, Please enter a number from 1 to 10 ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Incorrect Data Entry, Please enter a number from 1 to 10 " + ex.Message);
            }
        }

        private void BLUE_Slider_Scroll(object sender, EventArgs e)
        {
            BLUE_TextBox.Text = BLUE_Slider.Value.ToString();
        }

        private void GREEN_Slider_Scroll(object sender, EventArgs e)
        {
            GREEN_TextBox.Text = GREEN_Slider.Value.ToString();
        }
    }
    public class MAP
    {
            public int RESOLUTION=1;
            public Color lastColor;
            public Color AVE;
            public int RANGE = 3;
            double[,] filter; 
            private int height, width;
            private Color[,] Pixels;
            protected Color[,] originalPixels;
            protected Bitmap newImage, orignalImage;
            public MAP(Bitmap originalImage)
            {
                height = originalImage.Height;
                width = originalImage.Width;
                this.orignalImage = originalImage;
                Pixels = new Color[width, height];
                originalPixels = new Color[width, height];

                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Pixels[i, j] = originalImage.GetPixel(i, j);
                       originalPixels[i, j] = Pixels[i, j];
                }
                }
                newImage = new Bitmap(width, height);
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        newImage.SetPixel(i, j, Color.FromArgb(128, 128, 255));
                    }
                }
                findAverage();

            }

            public void findAverage()
            {
                int BLUE = 0, RED = 0, GREEN = 0, ALPHA = 0;
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        ALPHA += originalPixels[i, j].A;
                        BLUE += originalPixels[i, j].B;
                        RED += originalPixels[i, j].R;
                        GREEN += originalPixels[i, j].G;
                    }
                }
                int TOTAL = height * width;
                AVE = Color.FromArgb(ALPHA / TOTAL, RED / TOTAL, GREEN / TOTAL, BLUE / TOTAL);
            }

            /**
             * Generates Normal Map with all variables, variables are changeable in
             * other methods  
             * 
             *  X: -1 to +1 :  Red: 0 to 255
             *  Y: -1 to +1 :  Green: 0 to 255
             *  Z: 0 to -1 :  Blue: 128 to 255
             *  
             **/
            private void generate(){
            createFilter();
            int R = (RANGE - 1) / 2;
                    int pixelX=0;
                    int pixelY=0;
                    for (int i = 0; i < width; i++)
                    {
                        for (int j = 0; j < height; j++)
                            {
                            Color[,] A = new Color[R*2+1, R * 2 + 1];
                            for(int k = 0; k < RANGE; k++)
                            {
                                for (int l = 0; l < RANGE; l++)
                                {
                                    pixelX = i + k-R;
                                    pixelY = j + l-R;
                                //EDGE CATCHES, REVERTS TO EDGE
                                if (pixelX >= width) pixelX = width-1;
                                if (pixelX < 0) pixelX = 0;
                                if (pixelY < 0) pixelY = 0;
                                if (pixelY >= height) pixelY = height-1;

                                    A[k, l] = originalPixels[pixelX, pixelY];
                        }
                    }
                    Pixels[i, j] = alter(A);
                    lastColor = Pixels[i, j];
                }
                }
            }

        private Color cloneColor(Color c)
        {
            return Color.FromArgb(c.ToArgb());
        }


        private void createFilter()
        {
            int val = 0;
            double total = 0;
            filter = new double[RANGE, RANGE];
            for (int i = 0; i < (RANGE - 1) / 2 + 1; i++)
            {
                for (int j = i; j < (RANGE - 1) / 2 + 1; j++)
                {
                    val++;
                    filter[i, j] = val;
                    total += 4 * val;
                    if (i != j && j != (RANGE - 1) / 2)
                    {
                        total += 4 * val;
                    }
                }
            }
            total -= 3 * filter[(RANGE - 1) / 2, (RANGE - 1) / 2];
            for (int i = 0; i < (RANGE - 1) / 2 + 1; i++)
            {
                for (int j = i; j < (RANGE - 1) / 2 + 1; j++)
                {
                    filter[i, j] = filter[i, j] / total;
                    if (i != j)
                    {
                        filter[j, i] = filter[i, j];
                    }
                }
            }
            for (int i = 0; i < (RANGE - 1) / 2 + 1; i++)
            {
                for (int j = 0; j < (RANGE - 1) / 2+1; j++)
                {
                    
                    filter[RANGE - i-1, j] = filter[i, j];
                    filter[i, RANGE - j-1] = filter[i, j];
                    filter[RANGE - i-1, RANGE - j-1] = filter[i, j];


                }
            }
            outputArray(filter);
        }

        private void outputArray(double[,] d)
        {
            for(int i = 0; i < RANGE; i++)
            {
                for (int j = 0; j < RANGE; j++)
                {
                    try
                    {
                        Console.Out.Write(d[i, j].ToString("#.###"));
                    }catch(NullReferenceException ex)
                    {
                        Console.Out.Write("null");
                    }
                }
                Console.Out.WriteLine("");
                Console.Out.WriteLine("");
            }
        }
        /**
         * Alter
         * Alters the point based on points around it to indicate the direction of light 
         * then determines the intensity 
         * */
        private Color alter(Color[,] c)
        {
            int[,] intensity = new int[RANGE, RANGE];
            int max = 0;
            int[] xy = new int[]{ 0, 0 };
            for (int i = 0; i < RANGE; i++)
            {
                for(int j = 0; j < RANGE; j++)
                {
                    intensity[i, j] = compare(c[i, j], AVE);
                    if (i != ((RANGE - 1) / 2) && j!=((RANGE - 1) / 2))
                    {
                        int space = Math.Abs(intensity[i, j]);
                        if(max < space)
                        {
                            max = space; xy = new int[]{ i,j};
                        }
                    }
                }
            }

            if (max <= RESOLUTION) {
                return lastColor;
            }
            if (intensity[xy[0], xy[1]] < 0) {
                for (int i = 0; i < 2; i++)
                {
                    if (xy[i] == 0) { xy[i] = 2; }
                    if (xy[i] == 2) { xy[i] = 0; }
                }
            }
            int red = 0, green = 0;
            for (int k = 0; k < (intensity[xy[0], xy[1]])/3; k += RESOLUTION)
            {
                for (int i = 0; i < xy[0]; i++)
                {
                    
                    red += RESOLUTION;
                }
                for (int i = 0; i < xy[1]; i++)
                {
                    green += RESOLUTION;
                }
            }
            if (red > 255) red = 255;
            if (green > 255) green = 255;
            return Color.FromArgb(red, green,128); ;
        }


            private int compare(Color a, Color b)
            {
                return (a.B + a.R + a.G) - (b.B + b.R + b.G);
            }
            /**
             * GetBMP - Get Bitmap Image to display on screen
             * converts color array to bitmap, then returns it
             * 
             **/
            public Bitmap GetBMP()
            {
                generate();

                for (int i = 1; i < width; i++)
                {
                    for (int j = 1; j < height; j++)
                    {
                       newImage.SetPixel(i, j, Pixels[i, j]);
                     
                    }
                }
                return newImage;
            }
        }

     
    }