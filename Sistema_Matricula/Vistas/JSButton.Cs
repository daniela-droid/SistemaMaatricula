using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Matricula.Vistas
{
    public class JSButton 
    {

        // Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;
        private Color hoverBackColor = Color.LightGray;
        private Color originalBackColor;
        private Image buttonImage;
        private ContentAlignment imageAlignment = ContentAlignment.MiddleCenter;
        private const int imagePadding = 2; // Espacio entre la imagen y el borde

        //// Propiedades personalizadas
        //[Category("JS Code")]
        //public int BorderSize
        //{
        //    get { return borderSize; }
        //    set
        //    {
        //        borderSize = value;
        //        this.Invalidate();
        //    }
        //}

        //[Category("JS Code")]
        //public int BorderRadius
        //{
        //    get { return borderRadius; }
        //    set
        //    {
        //        borderRadius = value;
        //        this.Invalidate();
        //    }
        //}

        //[Category("JS Code")]
        //public Color BorderColor
        //{
        //    get { return borderColor; }
        //    set
        //    {
        //        borderColor = value;
        //        this.Invalidate();
        //    }
        //}

        //[Category("JS Code")]
        //public Color BackgroundColor
        //{
        //    get { return this.BackColor; }
        //    set
        //    {
        //        this.BackColor = value;
        //        originalBackColor = value;
        //    }
        //}

        //[Category("JS Code")]
        //public Color TextColor
        //{
        //    get { return this.ForeColor; }
        //    set { this.ForeColor = value; }
        //}

        //[Category("JS Code")]
        //public Color HoverBackColor
        //{
        //    get { return hoverBackColor; }
        //    set { hoverBackColor = value; }
        //}

        //[Category("JS Code")]
        //public Image ButtonImage
        //{
        //    get { return buttonImage; }
        //    set
        //    {
        //        buttonImage = value;
        //        AdjustPaddingForImage();
        //        this.Invalidate();
        //    }
        //}

        //[Category("JS Code")]
        //public ContentAlignment ImageAlignment
        //{
        //    get { return imageAlignment; }
        //    set
        //    {
        //        imageAlignment = value;
        //        AdjustPaddingForImage();
        //        this.Invalidate();
        //    }
        //}

        //// Ocultar la propiedad original de Image
        //[Browsable(false)]
        //public new Image Image
        //{
        //    get { return base.Image; }
        //    set { base.Image = null; } // No permitir que se asigne imagen aquí
        //}

        //[Browsable(false)]
        //public new ContentAlignment ImageAlign
        //{
        //    get { return base.ImageAlign; }
        //    set { base.ImageAlign = ContentAlignment.MiddleCenter; }
        //}


        //// Constructor
        //public JSButton()
        //{
        //    this.FlatStyle = FlatStyle.Flat;
        //    this.FlatAppearance.BorderSize = 0;
        //    this.Size = new Size(150, 40);
        //    this.BackColor = Color.MediumSlateBlue;
        //    this.ForeColor = Color.White;
        //    this.Resize += Button_Resize;

        //    originalBackColor = this.BackColor;

        //    // Eventos del mouse
        //    this.MouseEnter += RJButton_MouseEnter;
        //    this.MouseLeave += RJButton_MouseLeave;
        //}


        //private void AdjustPaddingForImage()
        //{
        //    if (buttonImage == null)
        //    {
        //        this.Padding = new Padding(0);
        //        return;
        //    }

        //    int imgWidth = ResizeImage(buttonImage, this.Height).Width + (imagePadding * 2);

        //    switch (imageAlignment)
        //    {
        //        case ContentAlignment.MiddleLeft:
        //            this.Padding = new Padding(imgWidth, imagePadding, imagePadding, imagePadding);
        //            break;
        //        case ContentAlignment.MiddleRight:
        //            this.Padding = new Padding(imagePadding, imagePadding, imgWidth, imagePadding);
        //            break;
        //        default:
        //            this.Padding = new Padding(imagePadding);
        //            break;
        //    }
        //}


        //// Métodos para cambiar color en hover
        //private void RJButton_MouseEnter(object sender, EventArgs e)
        //{
        //    this.BackColor = hoverBackColor;
        //}

        //private void RJButton_MouseLeave(object sender, EventArgs e)
        //{
        //    this.BackColor = originalBackColor;
        //}

        //// Redimensionar imagen proporcionalmente
        //private Image ResizeImage(Image img, int newHeight)
        //{
        //    if (img == null) return null;

        //    float scale = (float)(newHeight - (imagePadding * 2)) / img.Height;
        //    int newWidth = (int)(img.Width * scale);

        //    Bitmap resizedImage = new Bitmap(newWidth, newHeight - (imagePadding * 2));
        //    using (Graphics g = Graphics.FromImage(resizedImage))
        //    {
        //        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //        g.DrawImage(img, 0, 0, newWidth, resizedImage.Height);
        //    }

        //    return resizedImage;
        //}

      
        //protected override void OnPaint(PaintEventArgs pevent)
        //{
        //    base.OnPaint(pevent);

        //    Rectangle rectSurface = this.ClientRectangle;
        //    Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
        //    int smoothSize = (borderSize > 0) ? borderSize : 2;

        //    if (borderRadius > 2) // Botón redondeado
        //    {
        //        using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
        //        using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
        //        using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
        //        using (Pen penBorder = new Pen(borderColor, borderSize))
        //        {
        //            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        //            this.Region = new Region(pathSurface);
        //            pevent.Graphics.DrawPath(penSurface, pathSurface);

        //            if (borderSize >= 1)
        //                pevent.Graphics.DrawPath(penBorder, pathBorder);
        //        }
        //    }

        //    // Dibuja la imagen si existe
        //    if (buttonImage != null)
        //    {
        //        Image resizedImage = ResizeImage(buttonImage, this.Height - this.Padding.Vertical);
        //        int imgX = this.Padding.Left + imagePadding;
        //        int imgY = this.Padding.Top + (this.Height - this.Padding.Vertical - resizedImage.Height) / 2;

        //        // Alinear la imagen según ImageAlignment
        //        switch (imageAlignment)
        //        {
        //            case ContentAlignment.MiddleLeft:
        //                imgX = this.Padding.Left + imagePadding;
        //                break;
        //            case ContentAlignment.MiddleRight:
        //                imgX = this.Width - this.Padding.Right - resizedImage.Width - imagePadding;
        //                break;
        //            case ContentAlignment.MiddleCenter:
        //            default:
        //                imgX = (this.Width - resizedImage.Width) / 2;
        //                break;
        //        }

        //        pevent.Graphics.DrawImage(resizedImage, imgX, imgY);
        //    }
        //}


        //protected override void OnHandleCreated(EventArgs e)
        //{
        //    base.OnHandleCreated(e);
        //    this.Parent.BackColorChanged += Container_BackColorChanged;
        //}

        //private void Container_BackColorChanged(object sender, EventArgs e)
        //{
        //    this.Invalidate();
        //}

        //private void Button_Resize(object sender, EventArgs e)
        //{
        //    if (borderRadius > this.Height)
        //        borderRadius = this.Height;
        //    this.Invalidate(); // Redibujar el botón
        //}

        // Método para obtener bordes redondeados
        public GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}



