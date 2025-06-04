using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appComercio
{
    public static class EstiloBotoes
    {
        public static void AplicarEstiloArredondado(Button botao, Color corFundo, int raio = 20)
        {
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.BackColor =  corFundo;
            botao.ForeColor = Color.White;
            botao.Font = new Font("Segoe UI", 18, FontStyle.Bold);

            botao.SizeChanged += (s, e) =>
            {
                botao.Region = new Region(ObterPathArredondado(botao.ClientRectangle, raio));
            };

            // Aplica logo ao chamar
            botao.Region = new Region(ObterPathArredondado(botao.ClientRectangle, raio));

            Color corOriginal = corFundo;

            botao.MouseEnter += (s, e) => botao.BackColor = ControlPaint.Light(corOriginal);  // cor mais clara no hover
            botao.MouseLeave += (s, e) => botao.BackColor = corOriginal;
        }

        private static GraphicsPath ObterPathArredondado(Rectangle bounds, int raio)
        {
            int diametro = raio * 2;
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, diametro, diametro, 180, 90);
            path.AddArc(bounds.Right - diametro, bounds.Y, diametro, diametro, 270, 90);
            path.AddArc(bounds.Right - diametro, bounds.Bottom - diametro, diametro, diametro, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diametro, diametro, diametro, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
