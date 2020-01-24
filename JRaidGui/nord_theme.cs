
/// <summary>
/// Nord Theme
/// Author : THE LORD
/// Release Date : Friday, February 3, 2017
/// HF Account : https://hackforums.net/member.php?action=profile&uid=3304362
/// PM Me for any bug.
/// </summary>

#region NampeSpaces

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

#endregion

#region Helper Methods

public class HelperMethods
{

    public GraphicsPath GP = null;

    public enum MouseMode
    {
        NormalMode,
        Hovered,
        Pushed
    };

    public void DrawImageFromBase64(Graphics G, string Base64Image, Rectangle Rect)
    {
        Image IM = null;
        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(Convert.FromBase64String(Base64Image)))
        {
            IM = System.Drawing.Image.FromStream(ms);
        }
        G.DrawImage(IM, Rect);
    }

    public GraphicsPath RoundRec(Rectangle r, int Curve, bool TopLeft = true, bool TopRight = true, bool BottomLeft = true, bool BottomRight = true)
    {
        GraphicsPath CreateRoundPath = new GraphicsPath(FillMode.Winding);
        if (TopLeft)
        {
            CreateRoundPath.AddArc(r.X, r.Y, Curve, Curve, 180f, 90f);
        }
        else
        {
            CreateRoundPath.AddLine(r.X, r.Y, r.X, r.Y);
        }
        if (TopRight)
        {
            CreateRoundPath.AddArc(r.Right - Curve, r.Y, Curve, Curve, 270f, 90f);
        }
        else
        {
            CreateRoundPath.AddLine(r.Right - r.Width, r.Y, r.Width, r.Y);
        }
        if (BottomRight)
        {
            CreateRoundPath.AddArc(r.Right - Curve, r.Bottom - Curve, Curve, Curve, 0f, 90f);
        }
        else
        {
            CreateRoundPath.AddLine(r.Right, r.Bottom, r.Right, r.Bottom);

        }
        if (BottomLeft)
        {
            CreateRoundPath.AddArc(r.X, r.Bottom - Curve, Curve, Curve, 90f, 90f);
        }
        else
        {
            CreateRoundPath.AddLine(r.X, r.Bottom, r.X, r.Bottom);
        }
        CreateRoundPath.CloseFigure();
        return CreateRoundPath;
    }

    public void FillRoundedPath(Graphics G, Color C, Rectangle Rect, int Curve, bool TopLeft = true, bool TopRight = true, bool BottomLeft = true, bool BottomRight = true)
    {
        G.FillPath(new SolidBrush(C), RoundRec(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight));
    }

    public void FillRoundedPath(Graphics G, Brush B, Rectangle Rect, int Curve, bool TopLeft = true, bool TopRight = true, bool BottomLeft = true, bool BottomRight = true)
    {
        G.FillPath(B, RoundRec(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight));
    }

    public void DrawRoundedPath(Graphics G, Color C, Single Size, Rectangle Rect, int Curve, bool TopLeft = true, bool TopRight = true, bool BottomLeft = true, bool BottomRight = true)
    {
        G.DrawPath(new Pen(C, Size), RoundRec(Rect, Curve,TopLeft,TopRight,BottomLeft,BottomRight));
    }

    public void DrawTriangle(Graphics G, Color C, Single Size, Point P1_0, Point P1_1, Point P2_0, Point P2_1, Point P3_0, Point P3_1)
    {

        G.DrawLine(new Pen(C, Size), P1_0, P1_1);
        G.DrawLine(new Pen(C, Size), P2_0, P2_1);
        G.DrawLine(new Pen(C, Size), P3_0, P3_1);

    }

    public Pen PenRGBColor(int R, int G, int B, Single size)
    { return new Pen(System.Drawing.Color.FromArgb(R, G, B), size); }

    public Pen PenHTMlColor(String C_WithoutHash, float Thick)
    { return new Pen(GetHTMLColor(C_WithoutHash), Thick); }

    public SolidBrush SolidBrushRGBColor(int R, int G, int B, int A = 0)
    { return new SolidBrush(System.Drawing.Color.FromArgb(A, R, G, B)); }

    public SolidBrush SolidBrushHTMlColor(String C_WithoutHash)
    { return new SolidBrush(GetHTMLColor(C_WithoutHash)); }

    public Color GetHTMLColor(String C_WithoutHash)
    { return ColorTranslator.FromHtml("#" + C_WithoutHash); }

    public String ColorToHTML(Color C)
    { return ColorTranslator.ToHtml(C); }

    public Color SetARGB(int A, int R, int G, int B)
    { return System.Drawing.Color.FromArgb(A, R, G, B); }

    public Color SetRGB(int R, int G, int B)
    { return System.Drawing.Color.FromArgb(R, G, B); }

    public void CentreString(Graphics G, String Text, Font font, Brush brush, Rectangle Rect)
    { G.DrawString(Text, font, brush, new Rectangle(Rect.X, Rect.Y, Rect.Width, Rect.Height), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }); }

    public void LeftString(Graphics G, String Text, Font font, Brush brush, Rectangle Rect)
    {
        G.DrawString(Text, font, brush, new Rectangle(4, Rect.Y + Convert.ToInt32(Rect.Height / 2) - Convert.ToInt32(G.MeasureString(Text, font).Height / 2) + 0, Rect.Width, Rect.Height), new StringFormat { Alignment = StringAlignment.Near });
    }

    public void RightString(Graphics G, string Text, Font font, Brush brush, Rectangle Rect)
    {
        G.DrawString(Text, font, brush, new Rectangle(4, Convert.ToInt32(Rect.Y + (Rect.Height / 2) - (G.MeasureString(Text, font).Height / 2)), Rect.Width - Rect.Height + 10, Rect.Height), new StringFormat { Alignment = StringAlignment.Far });
    }
}

#endregion

#region Form

public class NordTheme : ContainerControl
{

    #region   Variables

    private static HelperMethods H = new HelperMethods();

    #endregion

    #region Draw Control

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics G = e.Graphics;
            Rectangle Rect = new Rectangle(0,0,Width,Height);
            G.FillRectangle(H.SolidBrushHTMlColor("bbd2d8"), Rect);
            G.FillRectangle(H.SolidBrushHTMlColor("174b7a"), new Rectangle(0, 0, Width, 58));
            G.FillRectangle(H.SolidBrushHTMlColor("164772"), new Rectangle(0, 58, Width, 10));
            G.DrawLine(H.PenHTMlColor("002e5e", 2), new Point(0, 68), new Point(Width, 68));

    }

    #endregion

    #region  Constructors

    public NordTheme()
    {

        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.ContainerControl, true);
        DoubleBuffered = true;
        UpdateStyles();

    }

    #endregion

    #region Events

    protected override void OnCreateControl()
    {

        base.OnCreateControl();
        ParentForm.Dock = DockStyle.None;
        Dock = DockStyle.Fill;
        Invalidate();

    }

    #endregion


}

#endregion

#region GroupBox

public class NordGroupBox : ContainerControl
{

    #region  Variables

    private static HelperMethods H = new HelperMethods();
    private Color _HeaderColor = H.GetHTMLColor("f8f8f9");
    private Color _HeaderTextColor = H.GetHTMLColor("dadada");
    private Color _BorderColor = H.GetHTMLColor("eaeaeb");
    private Color _BaseColor = Color.White;
   
    #endregion

    #region Draw Control

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics G = e.Graphics;

        Rectangle Rect = new Rectangle(0, 0, Width, Height);

            G.FillRectangle(new SolidBrush(BaseColor), Rect);
            G.FillRectangle(new SolidBrush(HeaderColor), new Rectangle(0, 0, Width, 50));

            G.DrawLine(new Pen(BorderColor, 1), new Point(0, 50), new Point(Width, 50));
            G.DrawRectangle(new Pen(BorderColor, 1), new Rectangle(0, 0, Width - 1, Height - 1));

            G.DrawString(Text, Font, new SolidBrush(HeaderTextColor), new Rectangle(5, 0, Width, 50), new StringFormat() {LineAlignment = StringAlignment.Center});

    }

    #endregion

    #region  Constructors

    public NordGroupBox()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.ContainerControl, true);
        DoubleBuffered = true;
        BackColor = Color.Transparent;
        Font = new Font("Segoe UI", 10);
        UpdateStyles();

    }

    #endregion
    
    #region  Properties

    [Category(" Custom Properties ")] 
    public Color HeaderColor
    {
        get
        {
            return _HeaderColor;
        }
        set
        {
            _HeaderColor=value;
            Invalidate();
        }
    }

    [Category(" Custom Properties ")] 
    public Color HeaderTextColor
    {
        get
        {
            return _HeaderTextColor;
        }
        set
        {
            _HeaderTextColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties ")] 
    public Color BorderColor
    {
        get
        {
            return _BorderColor;
        }
        set
        {
            _BorderColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties ")] 
    public Color BaseColor
    {
        get
        {
            return _BaseColor;
        }
        set
        {
            _BaseColor = value;
            Invalidate();
        }
    }

    #endregion
}

#endregion

#region Button

public class NordGreenButton : Control
{

    #region Variables

    private HelperMethods.MouseMode State;
    private static HelperMethods H = new HelperMethods();
    private Color _NormalColor = H.GetHTMLColor("75b81b");
    private Color _NormalBorderColor = H.GetHTMLColor("83ae48");
    private Color _NormalTextColor = Color.White;
    private Color _HoverColor = H.GetHTMLColor("8dd42e");
    private Color _HoverBorderColor = H.GetHTMLColor("83ae48");
    private Color _HoverTextColor = Color.White;
    private Color _PushedColor = H.GetHTMLColor("548710");
    private Color _PushedBorderColor = H.GetHTMLColor("83ae48");
    private Color _PushedTextColor = Color.White;

    #endregion

    #region Draw Control

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics G = e.Graphics;
        Rectangle Rect = new Rectangle(0, 0, Width - 1, Height - 1);

        G.SmoothingMode = SmoothingMode.AntiAlias;
        G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            switch (State)
            {
                case HelperMethods.MouseMode.NormalMode:
                   LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(0, Height - 5, Width - 1, Height - 1), 
                                                       Color.FromArgb(20, 0, 0, 0), Color.FromArgb(20, 0, 0, 0), 90f);
                    H.FillRoundedPath(G, H.SolidBrushHTMlColor("75b81b"), Rect, 5);
                    G.SmoothingMode = SmoothingMode.None;
                    H.FillRoundedPath(G, LGB, new Rectangle(0, Height - 5, Width - 1, Height - 5), 5,false,false,true,true);
                    G.SmoothingMode = SmoothingMode.AntiAlias;
                    H.DrawRoundedPath(G, H.GetHTMLColor("83ae48"), 1, Rect, 5);
                    H.CentreString(G, Text, new Font("Arial", 11, FontStyle.Bold), Brushes.White, Rect);
                    break;
                case HelperMethods.MouseMode.Hovered:
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, Height - 5, Width - 1, Height - 5), 
                                                       Color.FromArgb(20, 0, 0, 0), Color.FromArgb(20, 0, 0, 0), 90f);
                    H.FillRoundedPath(G, H.SolidBrushHTMlColor("8dd42e"), Rect, 5);
                    G.SmoothingMode = SmoothingMode.None;
                    H.FillRoundedPath(G, LGB1, new Rectangle(0, Height - 5, Width - 1, Height - 5), 5, false, false, true, true);
                    G.SmoothingMode = SmoothingMode.AntiAlias;
                    H.DrawRoundedPath(G, H.GetHTMLColor("83ae48"), 1, Rect, 5);
                    H.CentreString(G, Text, new Font("Arial", 11, FontStyle.Bold), Brushes.White, Rect);
                    break;
                case HelperMethods.MouseMode.Pushed:
                   LinearGradientBrush LGB2 = new LinearGradientBrush(new Rectangle(0, Height - 5, Width - 1, Height - 5), 
                                                       Color.FromArgb(20, 0, 0, 0), Color.FromArgb(20, 0, 0, 0), 90f);
                    H.FillRoundedPath(G, H.SolidBrushHTMlColor("548710"), Rect, 5);
                    G.SmoothingMode = SmoothingMode.None;
                    H.FillRoundedPath(G, LGB2, new Rectangle(0, Height - 5, Width - 1, Height - 5), 5, false, false, true, true);
                    G.SmoothingMode = SmoothingMode.AntiAlias;
                    H.DrawRoundedPath(G, H.GetHTMLColor("83ae48"), 1, Rect, 5);
                    H.CentreString(G, Text, new Font("Arial", 11, FontStyle.Bold), Brushes.White, Rect);
                    break;
            }

    }

    #endregion

    #region Properties

    [Category(" Custom Properties "),
    Description("Gets or sets the button color in normal mouse state")]
    public Color NormalColor
    {
        get
        {
            return _NormalColor;
        }
        set
        {
            _NormalColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the button border color in normal mouse state")]
    public Color NormalBorderColor
    {
        get
        {
            return _NormalBorderColor;
        }
        set
        {
            _NormalBorderColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the button Text color in normal mouse state")]
    public Color NormalTextColor
    {
        get
        {
            return _NormalTextColor;
        }
        set
        {
            _NormalTextColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the button color in hover mouse state")]
    public Color HoverColor
    {
        get
        {
            return _HoverColor;
        }
        set
        {
            _HoverColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the button border color in hover mouse state")]
    public Color HoverBorderColor
    {
        get
        {
            return _NormalBorderColor;
        }
        set
        {
            _NormalBorderColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the button Text color in hover mouse state")]
    public Color HoverTextColor
    {
        get
        {
            return _HoverTextColor;
        }
        set
        {
            _HoverTextColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the button color in mouse down state")]
    public Color PushedColor
    {
        get
        {
           return _PushedColor;
        }
        set
        {
            _PushedColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the button border color in mouse down state")]
    public Color PushedBorderColor
    {
        get
        {
            return _PushedBorderColor;
        }
        set
        {
            _PushedBorderColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the button Text color in mouse down state")]
    public Color PushedTextColor
    {
        get
        {
            return _PushedTextColor;
        }
        set
        {
            _PushedTextColor = value;
            Invalidate();
        }
    }

    #endregion

    #region Constructors

    public NordGreenButton()
    {
        SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint |
        ControlStyles.Selectable | ControlStyles.SupportsTransparentBackColor, true);
        DoubleBuffered = true;
        BackColor = Color.Transparent;
        Font = new Font("Segoe UI", 12, FontStyle.Bold);
        UpdateStyles();

    }

    #endregion

    #region Mouse Events

    protected override void OnMouseEnter(EventArgs e)
    {

        base.OnMouseEnter(e);
        State = HelperMethods.MouseMode.Hovered;
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {

        base.OnMouseUp(e);
        State = HelperMethods.MouseMode.Hovered;
        Invalidate();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {

        base.OnMouseDown(e);
        State = HelperMethods.MouseMode.Pushed;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {

        base.OnMouseLeave(e);
        State = HelperMethods.MouseMode.NormalMode;
        Invalidate();
    }

    #endregion
    
}

public class NordClearButton : Control
{

    #region Variables

    private HelperMethods.MouseMode State;
    private static HelperMethods H = new HelperMethods();
    private int _RoundRadius = 10;
    private bool _IsEnabled = true;

    #endregion

    #region Draw Control

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics G = e.Graphics;
       Rectangle Rect= new Rectangle(0, 0, Width - 1, Height - 1);

            G.SmoothingMode = SmoothingMode.AntiAlias;
            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            if (IsEnabled)
                switch(State)
                {
                    case HelperMethods.MouseMode.NormalMode:
                        H.DrawRoundedPath(G, H.GetHTMLColor("164772"), 1, Rect, RoundRadius);
                        H.CentreString(G, Text, new Font("Arial", 11, FontStyle.Regular), H.SolidBrushHTMlColor("164772"), Rect);
                        break;
                    case HelperMethods.MouseMode.Hovered:
                        H.FillRoundedPath(G, H.SolidBrushHTMlColor("eeeeee"), Rect, RoundRadius);
                        H.DrawRoundedPath(G, H.GetHTMLColor("d7d7d7"), 1, Rect, RoundRadius);
                        H.CentreString(G, Text, new Font("Arial", 9, FontStyle.Bold), H.SolidBrushHTMlColor("d7d7d7"), Rect);
                        break;
                    case HelperMethods.MouseMode.Pushed:
                        H.FillRoundedPath(G, H.SolidBrushHTMlColor("f3f3f3"), Rect, RoundRadius);
                        H.DrawRoundedPath(G, H.GetHTMLColor("d7d7d7"), 1, Rect, RoundRadius);
                        H.CentreString(G, Text, new Font("Arial", 9, FontStyle.Bold), H.SolidBrushHTMlColor("747474"), Rect);
                        break;
               }
            else
        {
                H.DrawRoundedPath(G, H.GetHTMLColor("dadada"), 1, Rect, 5);
                H.CentreString(G, Text, new Font("Arial", 9, FontStyle.Bold), H.SolidBrushHTMlColor("dadada"), Rect);

        }

    }

    #endregion

    #region Properties

    [Category(" Custom Properties ")] 
    public int RoundRadius
    {
        get
        {
            return _RoundRadius;
        }
        set
        {
            _RoundRadius = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties ")]
    public bool IsEnabled
    {
        get
        {
            return _IsEnabled;
        }
        set
        {
            Enabled = value;
            _IsEnabled = value;
            Invalidate();
        }
    }

    #endregion

    #region Constructors

    public NordClearButton()
    {
        SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint |
        ControlStyles.Selectable | ControlStyles.SupportsTransparentBackColor, true);
        DoubleBuffered = true;
        BackColor = Color.Transparent;
        Font = new Font("Segoe UI", 12, FontStyle.Bold);
        UpdateStyles();

    }

    #endregion

    #region Mouse Events

    protected override void OnMouseEnter(EventArgs e)
    {

        base.OnMouseEnter(e);
        State = HelperMethods.MouseMode.Hovered;
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {

        base.OnMouseUp(e);
        State = HelperMethods.MouseMode.Hovered;
        Invalidate();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {

        base.OnMouseDown(e);
        State = HelperMethods.MouseMode.Pushed;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {

        base.OnMouseLeave(e);
        State = HelperMethods.MouseMode.NormalMode;
        Invalidate();
    }

    #endregion 

}

#endregion

#region Switch

[DefaultEvent("Switch")]public class NordSwitchBlue : Control
{

    #region Variables

    private bool _Switched = false;
    private static HelperMethods H = new HelperMethods();
    private Color _UnCheckedColor = Color.Black;
    private Color _CheckedColor = H.GetHTMLColor("3075bb");
    private Color _CheckedBallColor = Color.White;
    private Color _UnCheckedBallColor = Color.Black;
    
    #endregion

    #region Constructors

    public NordSwitchBlue()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
        ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
        DoubleBuffered = true;
        UpdateStyles();
        BackColor = Color.Transparent;
        Cursor = Cursors.Hand;
        Font = new Font("Ubuntu", 10, FontStyle.Regular);
        Size = new Size(70, 28);
    }

    #endregion

    #region Properties

    [Category("Appearance")] public bool Switched
    {
        get { return _Switched; }

        set
        {
            _Switched = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control color while unchecked")]
    public Color UnCheckedColor
    {
        get
        {
            return _UnCheckedColor;
        }
        set
        {
            _UnCheckedColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control color while checked")]
    public Color CheckedColor
    {
        get
        {
            return _CheckedColor;
        }
        set
        {
            _CheckedColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control ball color while checked")]
    public Color CheckedBallColor
    {
        get
        {
            return _CheckedBallColor;
        }
        set
        {
            _CheckedBallColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control ball color while unchecked")]
    public Color UnCheckedBallColor
    {
        get
        {
            return _UnCheckedBallColor;
        }
        set
        {
            _UnCheckedBallColor = value;
            Invalidate();
        }
    }
    
    #endregion

    #region Draw Control

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics G = e.Graphics;
       
           G.SmoothingMode = SmoothingMode.AntiAlias;

            if (Switched)
            {
                H.FillRoundedPath(e.Graphics, new SolidBrush(CheckedColor), new Rectangle(0, 0, 40, 16), 16);
                G.FillEllipse(new SolidBrush(CheckedBallColor), new Rectangle(Width - Convert.ToInt32(14.5), Convert.ToInt32(2.7), 10, 10));
            }
                
            else
            {
                H.DrawRoundedPath(e.Graphics, UnCheckedColor, Convert.ToInt32(1.8), new Rectangle(0, 0, 40, 16), 16);
                G.FillEllipse(new SolidBrush(UnCheckedBallColor), new Rectangle(Convert.ToInt32(2.7), Convert.ToInt32(2.7), 10, 10));
            }


    }

    #endregion

    #region Events

    public event CheckedChangedEventHandler Switch;
    public delegate void CheckedChangedEventHandler(object sender);

    protected override void OnClick(EventArgs e)
    {

        _Switched = !_Switched;
        if (Switch != null)
        {
            Switch(this);
        }
        base.OnClick(e);
        Invalidate();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Size = new Size(42, 18);
    }

    #endregion

}

[DefaultEvent("Switch")]
public class NordSwitchGreen : Control
{

    #region Variables

    private bool _Switched = false;
    private static HelperMethods H = new HelperMethods();
    private Color _UnCheckedColor = H.GetHTMLColor("dedede");
    private Color _CheckedColor = H.GetHTMLColor("3acf5f");
    private Color _CheckedBallColor = Color.White;
    private Color _UnCheckedBallColor = Color.White;

    #endregion

    #region Constructors

    public NordSwitchGreen()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
        ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
        DoubleBuffered = true;
        UpdateStyles();
        BackColor = Color.Transparent;
        Cursor = Cursors.Hand;
        Size = new Size(30, 19); ;
    }

    #endregion

    #region Properties

    [Category("Appearance")]
    public bool Switched
    {
        get { return _Switched; }

        set
        {
            _Switched = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control color while unchecked")]
    public Color UnCheckedColor
    {
        get
        {
            return _UnCheckedColor;
        }
        set
        {
            _UnCheckedColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control color while checked")]
    public Color CheckedColor
    {
        get
        {
            return _CheckedColor;
        }
        set
        {
            _CheckedColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control ball color while checked")]
    public Color CheckedBallColor
    {
        get
        {
            return _CheckedBallColor;
        }
        set
        {
            _CheckedBallColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control ball color while unchecked")]
    public Color UnCheckedBallColor
    {
        get
        {
            return _UnCheckedBallColor;
        }
        set
        {
            _UnCheckedBallColor = value;
            Invalidate();
        }
    }
    
    #endregion

    #region Draw Control

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics G = e.Graphics;
       
            G.SmoothingMode = SmoothingMode.AntiAlias;
            if (Switched)
            {
                H.FillRoundedPath(e.Graphics, new SolidBrush(CheckedColor), new Rectangle(0, 1, 28, 16), 16);
                G.FillEllipse(new SolidBrush(CheckedBallColor), new Rectangle(Width - 17, 0, 16, 18));
            }
            else
            {
                H.FillRoundedPath(e.Graphics, new SolidBrush(UnCheckedColor), new Rectangle(0, 1, 28, 16), 16);
                G.FillEllipse(new SolidBrush(UnCheckedBallColor), new Rectangle(Convert.ToInt32(0.5), 0, 16, 18));
            }


    }

    #endregion

    #region Events

    public event CheckedChangedEventHandler Switch;
    public delegate void CheckedChangedEventHandler(object sender);

    protected override void OnClick(EventArgs e)
    {
        _Switched = !_Switched;
        if (Switch != null)
        {
            Switch(this);
        }
        base.OnClick(e);
        Invalidate();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Size = new Size(30, 19);
        Invalidate();
    }

    #endregion

}

[DefaultEvent("Switch")]
public class NordSwitchPower : Control
{

    #region Variables

    private bool _Switched = false;
    private static HelperMethods H = new HelperMethods();
    private Color _UnCheckedColor = H.GetHTMLColor("103859");
    private Color _CheckedColor = H.GetHTMLColor("103859");
    private Color _CheckedBallColor = H.GetHTMLColor("f1f1f1");
    private Color _UnCheckedBallColor = H.GetHTMLColor("f1f1f1");
    private Color _CheckedPowerColor = H.GetHTMLColor("73ba10");
    private Color _UnCheckedPowerColor = H.GetHTMLColor("c3c3c3");

    #endregion

    #region Constructors

    public NordSwitchPower()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
        ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
        DoubleBuffered = true;
        UpdateStyles();
        BackColor = Color.Transparent;
        Cursor = Cursors.Hand; 
    }

    #endregion

    #region Properties

    [Category("Appearance")]
    public bool Switched
    {
        get { return _Switched; }

        set
        {
            _Switched = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control color while unchecked")]
    public Color UnCheckedColor
    {
        get
        {
            return _UnCheckedColor;
        }
        set
        {
            _UnCheckedColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control color while checked")]
    public Color CheckedColor
    {
        get
        {
            return _CheckedColor;
        }
        set
        {
            _CheckedColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control ball color while checked")]
    public Color CheckedBallColor
    {
        get
        {
            return _CheckedBallColor;
        }
        set
        {
            _CheckedBallColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control ball color while unchecked")]
    public Color UnCheckedBallColor
    {
        get
        {
            return _UnCheckedBallColor;
        }
        set
        {
            _UnCheckedBallColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control power symbol color while checked")]
    public Color CheckedPowerColor
    {
        get
        {
            return _CheckedPowerColor;
        }
        set
        {
            _CheckedPowerColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the switch control power symbol color while unchecked")]
    public Color UnCheckedPowerColor
    {
        get
        {
            return _UnCheckedPowerColor;
        }
        set
        {
            _UnCheckedPowerColor = value;
            Invalidate();
        }
    }

    #endregion

    #region Draw Control

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics G = e.Graphics;

        G.SmoothingMode = SmoothingMode.AntiAlias;
            if (Switched)
            {
                H.FillRoundedPath(e.Graphics, new SolidBrush(CheckedColor), new Rectangle(0, 8, 55, 25), 20);
                G.FillEllipse(new SolidBrush(UnCheckedBallColor), new Rectangle(Width - 39, 0, 35, 40));
                G.DrawArc(new Pen(CheckedPowerColor, 2), Width - 31, 10, 19, Height - 23, -62, 300);
                G.DrawLine(new Pen(CheckedPowerColor, 2), Width - 22, 8, Width - 22, 17);
            }
            else
            {
                H.FillRoundedPath(e.Graphics, new SolidBrush(UnCheckedColor), new Rectangle(2, 8, 55, 25), 20);
                G.FillEllipse(new SolidBrush(UnCheckedBallColor), new Rectangle(0, 0, 35, 40));
                G.DrawArc(new Pen(UnCheckedPowerColor, 2), Convert.ToUInt32(7.5), 10, Width - 41, Height - 23, -62, 300);
                G.DrawLine(new Pen(UnCheckedPowerColor, 2), 17, 8, 17, 17);
            }

    }

    #endregion

    #region Events

    public event CheckedChangedEventHandler Switch;
    public delegate void CheckedChangedEventHandler(object sender);

    protected override void OnClick(EventArgs e)
    {

        _Switched = !_Switched;
        if (Switch != null)
        {
            Switch(this);
        }
        base.OnClick(e);
        Invalidate();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Size = new Size(60, 44);
    }

    #endregion

}

#endregion

#region RadioButton

[DefaultEvent("CheckedChanged")]public class NordRadioButton : Control
{

    #region Variables

    protected bool _Checked;
    protected HelperMethods.MouseMode State = HelperMethods.MouseMode.NormalMode;
    protected static int _Group = 1;
    public event CheckedChangedEventHandler CheckedChanged;
    public delegate void CheckedChangedEventHandler(object sender);
    private static HelperMethods H = new HelperMethods();
    private Color _CheckBorderColor = H.GetHTMLColor("164772");
    private Color _CheckColor = Color.Black;
    private Color _UnCheckBorderColor = Color.Black;

    #endregion

    #region Properties

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        Invalidate();
    }

    [Category("Appearance")]
    public bool Checked
    {
        get
        {
            return _Checked;
        }
        set
        {
            _Checked = value;
            UpdateCheckState();
            Invalidate();
        }
    }

    public int Group
    {
        get
        {
            return _Group;
        }
        set
        {
            _Group = value;
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the Radiobutton control check symbol color while checked")]
    public Color CheckColor
    {
        get
        {
            return _CheckColor;
        }
        set
        {
            _CheckColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the Radiobutton control border color while checked")]
    public Color CheckBorderColor
    {
        get
        {
            return _CheckBorderColor;
        }
        set
        {
            _CheckBorderColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the Radiobutton control border color while unchecked")]
    public Color UnCheckBorderColor
    {
        get
        {
            return _UnCheckBorderColor;
        }
        set
        {
            _UnCheckBorderColor = value;
            Invalidate();
        }
    }

    #endregion

    #region Draw Control

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics G = e.Graphics;
        Rectangle R = new Rectangle(1, 1, 18, 18);

            G.SmoothingMode = SmoothingMode.HighQuality;
            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            if (Checked)
            {
                G.FillEllipse(new SolidBrush(CheckColor), new Rectangle(4, 4, 12, 12));
                G.DrawEllipse(new Pen(CheckBorderColor, 2), R);
            }
            else
            {
                G.DrawEllipse(new Pen(UnCheckBorderColor, 2), R);
            }
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(21, Convert.ToInt32(1.5), Width, Height - 2), new StringFormat() {Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center});
    }

    #endregion

    #region Constructors

    public NordRadioButton()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
        DoubleBuffered = true;
        Cursor = Cursors.Hand;
        BackColor = Color.Transparent;
        ForeColor = H.GetHTMLColor("222222");
        Font = new Font("Segoe UI", 9, FontStyle.Regular);
        UpdateStyles();
    }

    #endregion

    #region  Events

    private void UpdateCheckState()
    {
        if (!IsHandleCreated || !_Checked)
            return;

        foreach (Control C in Parent.Controls)
        {
            if (!object.ReferenceEquals(C, this) && C is NordRadioButton && ((NordRadioButton)C).Group == _Group)
            {
                ((NordRadioButton)C).Checked = false;
            }
        }
        if (CheckedChanged != null)
        {
            CheckedChanged(this);
        }
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        if (!_Checked)
            Checked = true;
        base.OnMouseDown(e);
    }

    protected override void OnMouseHover(EventArgs e)
    {
        base.OnMouseHover(e);
        State = HelperMethods.MouseMode.Hovered;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        State = HelperMethods.MouseMode.NormalMode;
        Invalidate();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Height = 21;
        Invalidate();
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        UpdateCheckState();
    }

    #endregion

}

#endregion

#region CheckBox

[DefaultEvent("CheckedChanged")]public class NordCheckBox : Control
{

    #region Variables

    protected bool _Checked;
    protected HelperMethods.MouseMode State = HelperMethods.MouseMode.NormalMode;
    public event CheckedChangedEventHandler CheckedChanged;
    public delegate void CheckedChangedEventHandler(object sender);
    private static HelperMethods H = new HelperMethods();
    private Color _CheckColor = H.GetHTMLColor("5db5e9");
    private Color _BorderColor = H.GetHTMLColor("164772");

    #endregion

    #region Properties

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        Invalidate();
    }

    [Category("Appearance")]
    public bool Checked
    {
        get
        {
            return _Checked;
        }
        set
        {
            _Checked = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the Checkbox control color while checked")]
    public Color CheckColor
    {
        get
        {
            return _CheckColor;
        }
        set
        {
            _CheckColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the Checkbox control check symbol color while checked")]
    public Color BorderColor
    {
        get
        {
            return _BorderColor;
        }
        set
        {
            _BorderColor = value;
            Invalidate();
        }
    }

    #endregion

    #region Draw Control

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics G = e.Graphics;
        G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
        G.SmoothingMode = SmoothingMode.AntiAlias;
        using (GraphicsPath CheckBorder = new GraphicsPath() {FillMode = FillMode.Winding})
        {
            CheckBorder.AddArc(0, 0, 10, 8, 180, 90);
            CheckBorder.AddArc(8, 0, 8, 10, -90, 90);
            CheckBorder.AddArc(8, 8, 8, 8, 0, 70);
            CheckBorder.AddArc(0, 8, 10, 8, 90, 90);
            CheckBorder.CloseAllFigures();
            G.DrawPath(new Pen(BorderColor,(int)1.5), CheckBorder);
            if (Checked)
            {
                G.DrawString("b", new Font("Marlett", 13), new SolidBrush(CheckColor), new Rectangle(Convert.ToInt32(-2), Convert.ToInt32(0.5), Width, Height));
            }
        }

        G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(18, 1, Width, Height - 4), new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center });
    }

    #endregion

    #region Constructors

    public NordCheckBox()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
        DoubleBuffered = true;
        Cursor = Cursors.Hand;
        BackColor = Color.Transparent;
        ForeColor = H.GetHTMLColor("222222");
        Font = new Font("Segoe UI", 9, FontStyle.Regular);
        UpdateStyles();
    }

    #endregion

    #region  Events

    protected override void OnMouseHover(EventArgs e)
    {
        base.OnMouseHover(e);
        State = HelperMethods.MouseMode.Hovered;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        State = HelperMethods.MouseMode.NormalMode;
        Invalidate();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Height = 18;
        Invalidate();
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
    }

    protected override void OnClick(EventArgs e)
    {
        _Checked = !_Checked;
        if (CheckedChanged != null)
        {
            CheckedChanged(this);
        }
        base.OnClick(e);
        Invalidate();
    }

    #endregion

}

#endregion

#region TabControl

#region Horizental TabControl

public class NordHorizentalTabControl : TabControl
{

    #region Variables

    private static HelperMethods H = new HelperMethods();
    private Color _TabColor = H.GetHTMLColor("174b7a");
    private Color _TabPageColor = H.GetHTMLColor("bbd2d8");
    private Color _TabLowerColor = H.GetHTMLColor("164772");
    private Color _TabSelectedTextColor = Color.White;
    private Color _TabUnSlectedTextColor = H.GetHTMLColor("7188ad");

    #endregion

    #region Properties

    [Category(" Custom Properties "),
    Description("Gets or sets the tabcontrol header color")]
    public Color TabColor
    {
        get
        {
            return _TabColor;
        }
        set
        {
            _TabColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the tabpages color of the tabcontrol")]
    public Color TabPageColor
    {
        get
        {
            return _TabPageColor;
        }
        set
        {
            _TabPageColor = value;
            Invalidate();
        }
    }
    
    [Category(" Custom Properties "),
    Description("Gets or sets the tabcontrol line color below the header")]
    public Color TabLowerColor
    {
        get
        {
            return _TabLowerColor;
        }
        set
        {
            _TabLowerColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the tabcontrol Text color while unchecked")]
    public Color TabSelectedTextColor
    {
        get
        {
            return _TabSelectedTextColor;
        }
        set
        {
            _TabSelectedTextColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the tabcontrol Text color while unchecked")]
    public Color TabUnSlectedTextColor
    {
        get
        {
            return _TabUnSlectedTextColor;
        }
        set
        {
            _TabUnSlectedTextColor = value;
            Invalidate();
        }
    }

    #endregion

    #region Draw Control

    protected override void OnPaint(PaintEventArgs e)
    {
       
        Graphics G = e.Graphics;
       
            Cursor = Cursors.Hand;

            G.Clear(TabPageColor);

            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            G.FillRectangle(new SolidBrush(TabColor), new Rectangle(0, 0, Width, 60));

            G.FillRectangle(new SolidBrush(TabLowerColor), new Rectangle(0, 52, Width, 8));


            for (int i = 0; i <= TabCount - 1; i++)
            {
                Rectangle R = GetTabRect(i);
                if (i == SelectedIndex)
                {
                    G.DrawString(TabPages[i].Text, new Font("Helvetica CE", 9, FontStyle.Bold), new SolidBrush(TabSelectedTextColor), R.X + 30, R.Y + 20, new StringFormat() { Alignment = StringAlignment.Center });
                }
                else
                {
                    G.DrawString(TabPages[i].Text, new Font("Helvetica CE", 9, FontStyle.Bold), new SolidBrush(TabUnSlectedTextColor), R.X + 30, R.Y + 20, new StringFormat() {Alignment = StringAlignment.Center});
                }
            }

    }

    #endregion

    #region Constructors

    public NordHorizentalTabControl()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);
        DoubleBuffered = true;
        Alignment = TabAlignment.Top;
        SizeMode = TabSizeMode.Fixed;
        ItemSize = new Size(80, 55);
        Dock = DockStyle.None;
        UpdateStyles();

    }

    #endregion

    #region Events

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        foreach (TabPage Tab in base.TabPages)
        {
            Tab.BackColor = TabPageColor;
        }
    }

    #endregion

}

#endregion

#region Vertical TabControl

public class NordVerticalTabControl : TabControl
{

    #region Variables

    private static HelperMethods H = new HelperMethods();
    private Color _TabColor = H.GetHTMLColor("f6f6f6");
    private Color _TabPageColor = Color.White;
    private Color _TabSelectedTextColor = H.GetHTMLColor("174b7a");
    private Color _TabUnSelectedTextColor = Color.DarkGray;

    #endregion

    #region Draw Control

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics G = e.Graphics;
            
            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            G.FillRectangle(new SolidBrush(TabColor), new Rectangle(0, 0, ItemSize.Height, Height));
            G.FillRectangle(new SolidBrush(TabPageColor), new Rectangle(ItemSize.Height, 0, Width, Height));

            for (int i = 0; i <= TabCount - 1; i++)
            {
                Rectangle R = GetTabRect(i);
                if (i == SelectedIndex)
                {
                    H.CentreString(G, TabPages[i].Text, Font,new SolidBrush(TabSelectedTextColor), new Rectangle(R.X, R.Y + 5, R.Width - 4, R.Height));
                }
                else
                {
                    H.CentreString(G, TabPages[i].Text, Font, new SolidBrush(TabUnSelectedTextColor), new Rectangle(R.X, R.Y + 5, R.Width - 4, R.Height));
                }

                if (ImageList != null)
                {
                    G.DrawImage(ImageList.Images[i], new Rectangle(R.X + 9, R.Y + 10, 20, 20));
                }
            }
         
    }

    #endregion

    #region Constructors

    public NordVerticalTabControl()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true);
        DoubleBuffered = true;
        SizeMode = TabSizeMode.Fixed;
        Dock = DockStyle.None;
        ItemSize = new Size(35, 135);
        Alignment = TabAlignment.Left;
        Font = new Font("Segoe UI", 8);
        UpdateStyles();

    }

    #endregion

    #region Events

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        foreach (TabPage Tab in base.TabPages)
        {
            Tab.BackColor = TabPageColor;
        }
    }

    #endregion

    #region Properties

    [Category(" Custom Properties "),
    Description("Gets or sets the tabpages color of the tabcontrol")]
    public Color TabPageColor
    {
        get
        {
            return _TabPageColor;
        }
        set
        {
            _TabPageColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the tabcontrol left side color")]
    public Color TabColor
    {
        get
        {
            return _TabColor;
        }
        set
        {
            _TabColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the tabcontrol Text color while selected")]
    public Color TabSelectedTextColor
    {
        get
        {
            return _TabSelectedTextColor;
        }
        set
        {
            _TabSelectedTextColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the tabcontrol Text color while not selected")]
    public Color TabUnSelectedTextColor
    {
        get
        {
            return _TabUnSelectedTextColor;
        }
        set
        {
            _TabUnSelectedTextColor = value;
            Invalidate();
        }
    }

    #endregion

}

#endregion

#endregion

#region Textbox
[DefaultEvent("TextChanged")]public class NordTextbox : Control
{

    #region Variables

    private TextBox T = new TextBox();
    private HorizontalAlignment _TextAlign = HorizontalAlignment.Left;
    private int _MaxLength = 32767;
    private bool _ReadOnly;
    private bool _UseSystemPasswordChar = false;
    private string _WatermarkText = "";
    private Image _SideImage;
    private bool _Multiline = false;
    protected HelperMethods.MouseMode State = HelperMethods.MouseMode.NormalMode;
    private static HelperMethods H = new HelperMethods();
    private Color TBC = H.GetHTMLColor("bbd2d8");
    private Color TFC = H.GetHTMLColor("eaeaeb");
    private Color _BackColor = H.GetHTMLColor("eaeaeb");
    private Color _NormalLineColor = H.GetHTMLColor("eaeaeb");
    private Color _HoverLineColor = H.GetHTMLColor("fc3955");
    private Color _PushedLineColor = H.GetHTMLColor("fc3955");

    #endregion

    #region  Native Methods
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]
string lParam);

    #endregion

    #region Draw Control

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics G = e.Graphics;
       
           G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            switch(State)
            {
                case HelperMethods.MouseMode.NormalMode:
                    G.DrawLine(new Pen(NormalLineColor, 1), new Point(0, 29), new Point(Width, 29));
                    break;
                case HelperMethods.MouseMode.Hovered:
                    G.DrawLine(new Pen(HoverLineColor, 1), new Point(0, 29), new Point(Width, 29));
                    break;
                case HelperMethods.MouseMode.Pushed:
                    G.DrawLine(new Pen(PushedLineColor, 1), new Point(0, 29), new Point(Width, 29));
                    break;
            }

            if (SideImage !=null)
            {
                T.Location = new Point(33, 5);
                T.Width = Width - 60;
                G.InterpolationMode = InterpolationMode.HighQualityBicubic;
                G.DrawImage(SideImage, new Rectangle(8, 5, 16, 16));
            }
            else
            {
                T.Location = new Point(7, 5);
                T.Width = Width - 10;
            }

            if (ContextMenuStrip !=null)
                T.ContextMenuStrip = ContextMenuStrip;
    }

    #endregion

    #region Initialization

    public NordTextbox()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.SupportsTransparentBackColor, true);
        DoubleBuffered = true;
        UpdateStyles();
        BackColor = TBC;
        Size = new Size(135, 30);
        Font = new Font("Segoe UI", 11, FontStyle.Regular);
        T.Multiline = _Multiline;
        T.Cursor = Cursors.IBeam;
        T.BackColor = BackColor;
        T.ForeColor = TFC;
        T.BorderStyle = BorderStyle.None;
        T.Location = new Point(7, 8);
        T.Font = Font;
        T.Size = new Size(Width - 10, 30);
        T.UseSystemPasswordChar = _UseSystemPasswordChar;
        T.TextChanged += T_TextChanged;
        T.MouseDown += T_MouseDown;
        T.MouseEnter += T_MouseEnter;
        T.MouseUp += T_MouseUp;
        T.MouseLeave += T_MouseLeave;
        T.MouseHover += T_MouseHover;
        T.KeyDown += T_KeyDown;
    }

    #endregion

    #region Properties

    [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public BorderStyle BorderStyle
    {
        get
        {
            return BorderStyle.None;
        }
    }

    [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool Multiline
    {
        get
        {
            return _Multiline;
        }
        set
        {
            _Multiline = value;
            if (T != null)
            {
                T.Multiline = value;
            }

        }
    }

    [Category("Appearance"),
    Description("Gets or sets how text is aligned in a System.Windows.Forms.TextBox control.")]
    public HorizontalAlignment TextAlign
    {
        get
        {
            return _TextAlign;
        }
        set
        {
            _TextAlign = value;
            if (T != null)
            {
                T.TextAlign = value;
            }
        }
    }

    [Category("Behavior"),
    Description("Gets or sets how text is aligned in a System.Windows.Forms.TextBox control.")]
    public int MaxLength
    {
        get
        {
            return _MaxLength;
        }
        set
        {
            _MaxLength = value;
            if (T != null)
            {
                T.MaxLength = value;
            }
        }
    }

    [Category("Behavior"),
    Description("Gets or sets a value indicating whether text in the text box is read-only.")]
    public bool ReadOnly
    {
        get
        {
            return _ReadOnly;
        }
        set
        {
            _ReadOnly = value;
            if (T != null)
            {
                T.ReadOnly = value;
            }
        }
    }

    [Category("Behavior"),
    Description("Gets or sets a value indicating whether the text in the System.Windows.Forms.TextBox control should appear as the default password character.")]
    public bool UseSystemPasswordChar
    {
        get
        {
            return _UseSystemPasswordChar;
        }
        set
        {
            _UseSystemPasswordChar = value;
            if (T != null)
            {
                T.UseSystemPasswordChar = value;
            }
        }
    }

    [Category("Custom Properties "),
    Description("Gets or sets the text in the System.Windows.Forms.TextBox while being empty.")]
    public string WatermarkText
    {
        get
        {
            return _WatermarkText;
        }
        set
        {
            _WatermarkText = value;
            SendMessage(T.Handle, 0x1501, 0, value);
            Invalidate();
        }
    }

    [Category("Custom Properties "),
    Description("Gets or sets the image of the control.")]
    public Image SideImage
    {
        get
        {
            return _SideImage;
        }
        set
        {
            _SideImage = value;
            Invalidate();
        }
    }

    [Browsable(false)]
    public override Image BackgroundImage
    {
        get
        {
            return base.BackgroundImage;
        }
        set
        {
            base.BackgroundImage = value;
        }
    }

    [Browsable(false)]
    public override ImageLayout BackgroundImageLayout
    {
        get
        {
            return base.BackgroundImageLayout;
        }
        set
        {
            base.BackgroundImageLayout = value;
        }
    }

    [Category("Appearance"),
    Description("Gets or sets the current text in the System.Windows.Forms.TextBox.")]
    public override string Text
    {
        get
        {
            return base.Text;
        }
        set
        {
            base.Text = value;
            if (T != null)
            {
                T.Text = value;
            }
        }
    }

    [Category("Appearance"),
    Description("Gets or sets the background color of the control.")]
    public override Color BackColor     
    {
    get
    {
        return _BackColor;
    }
    
    set
        {
            base.BackColor = value;
            _BackColor = value;
            T.BackColor = value;
            Invalidate();
        }
    }

    [Category("Custom Properties "),
    Description("Gets or sets the lower line color of the control in normal mouse state.")]
    public Color NormalLineColor
    {
        get
        {
            return _NormalLineColor;
        }

        set
        {
            _NormalLineColor = value;
            Invalidate();
        }
    }

    [Category("Custom Properties "),
    Description("Gets or sets the lower line color of the control in mouse hover state.")]
    public Color HoverLineColor
    {
        get
        {
            return _HoverLineColor;
        }

        set
        {
            _HoverLineColor = value;
            Invalidate();
        }
    }

    [Category("Custom Properties "),
    Description("Gets or sets the lower line color of the control in mouse down state.")]
    public Color PushedLineColor
    {
        get
        {
            return _PushedLineColor;
        }

        set
        {
            _PushedLineColor = value;
            Invalidate();
        }
    }
    #endregion

    #region Events

    private void T_MouseHover(object sender, EventArgs e)
    {
        State = HelperMethods.MouseMode.Hovered;

    }

    private void T_MouseLeave(object sender, EventArgs e)
    {
        State = HelperMethods.MouseMode.NormalMode;

    }

    private void T_MouseUp(object sender, EventArgs e)
    {
        State = HelperMethods.MouseMode.Pushed;

    }

    private void T_MouseEnter(object sender, EventArgs e)
    {
        State = HelperMethods.MouseMode.Pushed;

    }

    private void T_MouseDown(object sender, EventArgs e)
    {
        State = HelperMethods.MouseMode.Pushed;

    }

    private void T_TextChanged(object sender, EventArgs e)
    {
        Text = T.Text;
    }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        T.Text = Text;
    }

    private void T_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.A) { e.SuppressKeyPress = true; }
        if (e.Control && e.KeyCode == Keys.C)
        {
            T.Copy();
            e.SuppressKeyPress = true;
        }
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        if (!Controls.Contains(T))
            Controls.Add(T);
        if (T.Text == "" && WatermarkText != "")

            T.Text = WatermarkText;

    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        if (_Multiline == false)
            Height = 30;
    }

    #endregion


}

#endregion

#region ComboBox

public class NordComboBox : ComboBox
{

    #region Variables

    private int _StartIndex = 0;
    private static HelperMethods H = new HelperMethods();
    private Color _BaseColor = H.GetHTMLColor("bbd2d8");
    private Color _LinesColor = H.GetHTMLColor("75b81b");
    private Color _TextColor = Color.Gray;
 
    #endregion

    #region Constructors

    public NordComboBox()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint |
              ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
        DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
        DoubleBuffered = true;
        StartIndex = 0;
        DropDownHeight = 100;
        BackColor = H.GetHTMLColor("291a2a");
        Font = new Font("Segoe UI", 12, FontStyle.Regular);
        DropDownStyle = ComboBoxStyle.DropDownList;
        UpdateStyles();

    }

    #endregion

    #region Properties

    [Category("Behavior"),
    Description("When overridden in a derived class, gets or sets the zero-based index of the currently selected item.")]
    public int StartIndex
    {
        get
        {
            return _StartIndex;
        }
        set
        {
            _StartIndex = value;
            try
            {
                base.SelectedIndex = value;
            }
            catch
            {

            }
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the background color for the control.")]
    public Color BaseColor
    {
        get
        {
            return _BaseColor;
        }
        set
        {
            _BaseColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the lines color for the control.")]
    public Color LinesColor
    {
        get
        {
            return _LinesColor;
        }
        set
        {
            _LinesColor = value;
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the text color for the control.")]
    public Color TextColor
    {
        get
        {
            return _TextColor;
        }
        set
        {
            _TextColor = value;
            Invalidate();
        }
    }

    #endregion

    #region Draw Control

    protected override void OnPaint(PaintEventArgs e)
    {
       Graphics G = e.Graphics;
      
            Rectangle Rect = new Rectangle(0, 0, Width, Height - 1);

            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            G.FillRectangle(new SolidBrush(BaseColor), Rect);

            G.DrawLine(new Pen(LinesColor, 2), new Point(Width - 21, (Height / 2) - 3), new Point(Width - 7, (Height / 2) - 3));
            G.DrawLine(new Pen(LinesColor, 2), new Point(Width - 21, (Height / 2) + 1), new Point(Width - 7, (Height / 2) + 1));
            G.DrawLine(new Pen(LinesColor, 2), new Point(Width - 21, (Height / 2) + 5), new Point(Width - 7, (Height / 2) + 5));

            G.DrawLine(new Pen(LinesColor, 1), new Point(0, Height - 1), new Point(Width, Height - 1));
            G.DrawString(Text, Font, new SolidBrush(TextColor), new Rectangle(5, 1, Width - 1, Height - 1), new StringFormat() {LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Near});

    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        try
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            e.Graphics.FillRectangle(new SolidBrush(BaseColor), e.Bounds);
            if (System.Convert.ToInt32((e.State & DrawItemState.Selected)) == (int)DrawItemState.Selected)
            {
                if (!(e.Index == -1))
                {
                    Cursor = Cursors.Hand;
                    H.CentreString(e.Graphics, GetItemText(Items[e.Index]), Font, new SolidBrush(TextColor), new Rectangle(e.Bounds.X + 1, e.Bounds.Y + 3, e.Bounds.Width - 2, e.Bounds.Height - 2));
                }
            }
            else
            {
                if (!(e.Index == -1))
                {
                    H.CentreString(e.Graphics, GetItemText(Items[e.Index]), Font, Brushes.DimGray, new Rectangle(e.Bounds.X + 1, e.Bounds.Y + 2, e.Bounds.Width - 2, e.Bounds.Height - 2));
                }
            }

        }
        catch
        {

        }
        Invalidate();
    }

    #endregion

    #region Events

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Invalidate();
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();

    }

    protected override void OnLostFocus(EventArgs e)
    {
        base.OnLostFocus(e);
        SuspendLayout();
        Update();
        ResumeLayout();
    }

    #endregion

}

#endregion

#region Seperator

public class NordSeperator : Control
{

    #region Variables

    private Style _SepStyle = Style.Horizental;
    private static HelperMethods H = new HelperMethods();
    private Color _SeperatorColor = H.GetHTMLColor("eaeaeb");

    #endregion

    #region Constructors

    public NordSeperator()
    {
        SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint |
        ControlStyles.ResizeRedraw | ControlStyles.UserPaint |
        ControlStyles.SupportsTransparentBackColor, true);
        DoubleBuffered = true;
        BackColor = Color.Transparent;
        UpdateStyles();

    }

    #endregion

    #region Enumerators

    public enum Style
    {
        Horizental,
        Vertiacal
    };

    #endregion

    #region Properties

    [Category("Appearance"),
    Description("Gets or sets the style for the control.")]
    public Style SepStyle
    {
        get
        {
            return _SepStyle;
        }
        set
        {
            _SepStyle = value;
            if (value == Style.Horizental)
            {
                Height = 4;
            }
            else
            {
                Width = 4;
            }
            Invalidate();
        }
    }

    [Category(" Custom Properties "),
    Description("Gets or sets the color for the control.")]
    public Color SeperatorColor
    {
        get
        {
            return _SeperatorColor;
        }
        set
        {
            _SeperatorColor = value;
            Invalidate();
        }
    }

    #endregion

    #region DrawControl

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics G = e.Graphics;

            switch (SepStyle)
            {
                case Style.Horizental:
                    G.DrawLine(new Pen(SeperatorColor), 0, 1, Width, 1);
                    break;
                case Style.Vertiacal:
                    G.DrawLine(new Pen(SeperatorColor), 1, 0, 1, Height);
                    break;
            }

    }

    #endregion

    #region Events

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        if (SepStyle == Style.Horizental) { Height = 4; } else { Width = 4; }
    }

    #endregion

}

#endregion

#region Label

[DefaultEvent("TextChanged")]public class NordLabel : Control
{
    #region Variables

    private static HelperMethods H = new HelperMethods();

    #endregion

    #region Constructors

    public NordLabel()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        DoubleBuffered = true;
        BackColor = Color.Transparent;
        Font = new Font("Segoe UI", 12, FontStyle.Regular);
        UpdateStyles();
    }

    #endregion

    #region DrawControl

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
        e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle);

    }

    #endregion

    #region Events

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Height = Font.Height + 2;
    }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
    }

    #endregion;

}

#endregion

#region Link Label

[DefaultEvent("TextChanged")]public class NordLinkLabel : Control
{

    #region Variables

    private HelperMethods.MouseMode State;
    private static HelperMethods H = new HelperMethods();
    private Color _HoverColor = Color.SteelBlue;
    private Color _PushedColor = Color.DarkBlue;

    #endregion

    #region Properties

    [Category("Custom Properties "),
    Description("Gets or sets the tect color of the control in mouse hover state.")]
    public Color HoverColor
    {
        get
        {
            return _HoverColor;
        }
        set
        {
            _HoverColor = value;
            Invalidate();
        }
    }

    [Category("Custom Properties "),
    Description("Gets or sets the text color of the control in mouse down state.")]
    public Color PushedColor
    {
        get
        {
            return _PushedColor;
        }
        set
        {
            _PushedColor = value;
            Invalidate();
        }
    }

    #endregion

    #region Constructors

    public NordLinkLabel()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        DoubleBuffered = true;
        BackColor = Color.Transparent;
        ForeColor = Color.MediumBlue;
        Font = new Font("Segoe UI", 12, FontStyle.Underline);
        UpdateStyles();
    }

    #endregion

    #region DrawControl

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
        switch (State)
        {
            case HelperMethods.MouseMode.NormalMode:
                e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle);
                break;
            case HelperMethods.MouseMode.Hovered:
                Cursor = Cursors.Hand;
                e.Graphics.DrawString(Text, Font, new SolidBrush(HoverColor), ClientRectangle);
                break;
            case HelperMethods.MouseMode.Pushed:
                e.Graphics.DrawString(Text, Font, new SolidBrush(PushedColor), ClientRectangle);
                break;
        }

    }

    #endregion

    #region Events

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Height = Font.Height + 2;
    }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
    }


    protected override void OnMouseEnter(EventArgs e)
    {

        base.OnMouseEnter(e);
        State = HelperMethods.MouseMode.Hovered;
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {

        base.OnMouseUp(e);
        State = HelperMethods.MouseMode.Hovered;
        Invalidate();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {

        base.OnMouseDown(e);
        State = HelperMethods.MouseMode.Pushed;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {

        base.OnMouseLeave(e);
        State = HelperMethods.MouseMode.NormalMode;
        Invalidate();
    }

    #endregion;

}

#endregion