using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        



      

        public Form1()
        {
            InitializeComponent();
        }

        private void btSeleciona(object sender, EventArgs e)
        {
            OpenFileDialog caixa = new OpenFileDialog();
            Bitmap Imagem;
            // caixa.Filter = "Imagem JPG(.jpg,.bmp,.gif, .png, .tif)|*.jpg ||*.bmp|| *gif|| *png|";
            caixa.Filter = "Imagem JPG(.jpg)|*.jpg|Imagme bmp(.bmp)|*.bmp|Imagem Gif(.Gif)|*gif|Imagem Png(.png)|*png|Imagem TIFF(.tif)|*tif";
            caixa.InitialDirectory = @"C:\Users\'\Desktop\Imagem Trabalho";
            caixa.Title = "Selecionar Imagem";
            if (caixa.ShowDialog() == DialogResult.OK)
            {
                Imagem = new Bitmap(Image.FromFile(caixa.FileName));
                ImagemOriginal.Image = Imagem;
            }
        }

        private void btSalvar(object sender, EventArgs e)
        {
            SaveFileDialog caixa = new SaveFileDialog();
            caixa.Filter = "Imagem jpeg(.jpg)|*jpg";
            caixa.DefaultExt = "jpg";
            caixa.Title = "Salvar Imagem";
            if (DialogResult.OK == caixa.ShowDialog())
            {
                string nome = caixa.FileName;
                Bitmap NovaImagem = new Bitmap(ImagemResultado.Image);
                NovaImagem.Save(nome, System.Drawing.Imaging.ImageFormat.Png);
                
            }

        }


        private void btNegativo(object sender, EventArgs e)
        {
            Bitmap original = new Bitmap(ImagemOriginal.Image);
            Bitmap NovaImagem = new Bitmap(original.Width, original.Height);
            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    Color originalColor = original.GetPixel(i, j);//pega a cor original
                    Color CorEmNegativo = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B); // transforma em negativo

                    NovaImagem.SetPixel(i, j, CorEmNegativo);


                }
            }
            ImagemResultado.Image = NovaImagem;
        }

        private void btSepia(object sender, EventArgs e)
        {
            Bitmap original = new Bitmap(ImagemOriginal.Image);
            Bitmap NovaImagem = new Bitmap(original.Width, original.Height);

            //pega a dimensão da imagem
            int width = original.Width;
            int height = original.Height;

            //cor do pixel
            Color p;

            //sepia
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    p = original.GetPixel(x, y);

                    
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    
                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    
                    if (tr > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = tr;
                    }

                    if (tg > 255)
                    {
                        g = 255;
                    }
                    else
                    {
                        g = tg;
                    }

                    if (tb > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tb;
                    }

                    
                    NovaImagem.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }

   


            ImagemResultado.Image = NovaImagem;

        }


        private void btBlur(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(ImagemOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int pixelR = 0;
            int pixelG = 0;
            int pixelB = 0;
            int pixelA = 0;
            int i, j;
            int[] todosPixeisR = new int[9];
            int[] todosPixeisG = new int[9];
            int[] todosPixeisB = new int[9];
            int[] todosPixeisA = new int[9];
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            
            for (i = 1; i < Largura - 1; i++)
            {
                for (j = 1; j < Altura - 1; j++)
                {
                    pixelR = (
                             Imagem.GetPixel(i - 1, j - 1).R +
                             Imagem.GetPixel(i - 1, j).R +
                             Imagem.GetPixel(i - 1, j + 1).R +

                             Imagem.GetPixel(i, j - 1).R +
                             Imagem.GetPixel(i, j).R +
                             Imagem.GetPixel(i, j + 1).R +

                             Imagem.GetPixel(i + 1, j - 1).R + 
                             Imagem.GetPixel(i + 1, j).R +
                             Imagem.GetPixel(i + 1, j + 1).R
                             ) / 9;

                    pixelG = (
                             Imagem.GetPixel(i - 1, j - 1).G +
                             Imagem.GetPixel(i - 1, j).G +
                             Imagem.GetPixel(i - 1, j + 1).G +

                             Imagem.GetPixel(i, j - 1).G +
                             Imagem.GetPixel(i, j).G +
                             Imagem.GetPixel(i, j + 1).G +

                             Imagem.GetPixel(i + 1, j - 1).G + 
                             Imagem.GetPixel(i + 1, j).G +
                             Imagem.GetPixel(i + 1, j + 1).G
                             ) / 9;

                    pixelB = (
                              Imagem.GetPixel(i - 1, j - 1).B +
                              Imagem.GetPixel(i - 1, j).B +
                              Imagem.GetPixel(i - 1, j + 1).B +

                              Imagem.GetPixel(i, j - 1).B +
                              Imagem.GetPixel(i, j).B +
                              Imagem.GetPixel(i, j + 1).B +

                              Imagem.GetPixel(i + 1, j - 1).B + 
                              Imagem.GetPixel(i + 1, j).B +
                              Imagem.GetPixel(i + 1, j + 1).B
                              ) / 9;

                    pixelA = (
                             Imagem.GetPixel(i - 1, j - 1).A +
                             Imagem.GetPixel(i - 1, j).A +
                             Imagem.GetPixel(i - 1, j + 1).A +

                             Imagem.GetPixel(i, j - 1).A +
                             Imagem.GetPixel(i, j).A +
                             Imagem.GetPixel(i, j + 1).A +

                             Imagem.GetPixel(i + 1, j - 1).A + 
                             Imagem.GetPixel(i + 1, j).A +
                             Imagem.GetPixel(i + 1, j + 1).A
                            ) / 9;


                    NovaImagem.SetPixel(i, j, Color.FromArgb(pixelA, pixelR, pixelG, pixelB));

                }
            }

            ImagemResultado.Image = NovaImagem;
        }

        private void btPretoBranco(object sender, EventArgs e) 
        {
            Bitmap original = new Bitmap(ImagemOriginal.Image);
            Bitmap NovaImagem = new Bitmap(original.Width, original.Height);

            //get image dimension
            int width = original.Width;
            int height = original.Height;

            for(int i =0; i< original.Height; i++)
            {
                for(int j = 0; j< original.Width; j++)
                {
                    if (original.GetPixel(j, i).R >= 128 && original.GetPixel(j, i).G >= 128 && original.GetPixel(j, i).B >= 128)
                        NovaImagem.SetPixel(j, i, Color.FromArgb(255, 255, 255));
                    else
                        NovaImagem.SetPixel(j, i, Color.FromArgb(0, 0, 0));
                }
            }
            ImagemResultado.Image = NovaImagem;

        }

        


       

        private void btBordaPreta(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(ImagemOriginal.Image);
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int[,] Prewittx = new int[,] { { -1, -1, -1 }, { 0, 0, 0 }, { 1, 1, 1 } };
            int[,] Prewitty = new int[,] { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };
            int[,] todosPixeisR = new int[Largura, Altura];
            int[,] todosPixeisG = new int[Largura, Altura];
            int[,] todosPixeisB = new int[Largura, Altura];
            Bitmap NovaImagem = new Bitmap(Largura, Altura); //para trabalhar com a imagem, novo bmp com o mesmo tamanho da img original
            int limite = 128 * 128;
            for (int i = 0; i < Largura; i++)
            {
                for (int j = 0; j < Altura; j++)
                {
                    todosPixeisR[i, j] = Imagem.GetPixel(i, j).R;
                    todosPixeisG[i, j] = Imagem.GetPixel(i, j).G;
                    todosPixeisB[i, j] = Imagem.GetPixel(i, j).B;
                }
            }
            int novo_rx, novo_ry, novo_gx, novo_gy, novo_bx, novo_by;//, rc, gc, bc;
            for (int i = 1; i < Imagem.Width - 1; i++)
            {
                for (int j = 1; j < Imagem.Height - 1; j++)
                {
                    novo_rx = 0;
                    novo_ry = 0;
                    novo_gx = 0;
                    novo_gy = 0;
                    novo_bx = 0;
                    novo_by = 0;
                    for (int x = -1; x < 2; x++)
                    {
                        for (int y = -1; y < 2; y++)
                        {
                            novo_rx += Prewittx[x + 1, y + 1] * todosPixeisR[i + y, j + x];
                            novo_ry += Prewitty[x + 1, y + 1] * todosPixeisR[i + y, j + x];
                            novo_gx += Prewittx[x + 1, y + 1] * todosPixeisG[i + y, j + x];
                            novo_gy += Prewitty[x + 1, y + 1] * todosPixeisG[i + y, j + x];
                            novo_bx += Prewittx[x + 1, y + 1] * todosPixeisB[i + y, j + x];
                            novo_by += Prewitty[x + 1, y + 1] * todosPixeisB[i + y, j + x];
                        }
                    }
                    if (
                        novo_rx * novo_rx + novo_ry * novo_ry > limite ||
                        novo_gx * novo_gx + novo_gy * novo_gy > limite ||
                        novo_bx * novo_bx + novo_by * novo_by > limite
                        )
                        NovaImagem.SetPixel(i, j, Color.Black);
                    else
                        NovaImagem.SetPixel(i, j, Color.Transparent);
                }
            }
            ImagemResultado.Image = NovaImagem;
        }


       


        


        private void btGrayscale(object sender, EventArgs e)
        {
            Bitmap Imagem = new Bitmap(ImagemOriginal.Image);

            int todospixelsR;
            int todospixelsG;
            int todospixelsB;
            int Largura = Imagem.Width;
            int Altura = Imagem.Height;
            int cinza;
            Bitmap NovaImagem = new Bitmap(Largura, Altura);
            for (int x = 0; x < Largura; x++)
            {
                for (int y = 0; y < Altura; y++)
                {
                    todospixelsR = Imagem.GetPixel(x, y).R;
                    todospixelsG = Imagem.GetPixel(x, y).G;
                    todospixelsB = Imagem.GetPixel(x, y).B;
                    cinza = (todospixelsR + todospixelsG + todospixelsB) / 3;
                    NovaImagem.SetPixel(x, y, Color.FromArgb(255, cinza, cinza, cinza));
                }
            }
            ImagemResultado.Image = NovaImagem;
        }

        private void campoImagemOriginal(object sender, EventArgs e)
        {

        }


    
    }
    }

    
