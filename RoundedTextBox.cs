using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedTextBox : TextBox
{
    private int _borderRadius = 15;
    private Color _borderColor = Color.Gray;
    private int _borderSize = 2;

    public int BorderRadius
    {
        get => _borderRadius;
        set { _borderRadius = value; this.Invalidate(); }
    }

    public Color BorderColor
    {
        get => _borderColor;
        set { _borderColor = value; this.Invalidate(); }
    }

    public int BorderSize
    {
        get => _borderSize;
        set { _borderSize = value; this.Invalidate(); }
    }

    public RoundedTextBox()
    {
        this.BorderStyle = BorderStyle.None;
        this.Padding = new Padding(10, 7, 10, 7);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Dibujar el borde redondeado
        using (GraphicsPath path = GetRoundedRectanglePath(ClientRectangle, _borderRadius))
        using (Pen penBorder = new Pen(_borderColor, _borderSize))
        {
            penBorder.Alignment = PenAlignment.Inset;
            graphics.DrawPath(penBorder, path);
        }
    }

    private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
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

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        this.Invalidate();
    }
}
