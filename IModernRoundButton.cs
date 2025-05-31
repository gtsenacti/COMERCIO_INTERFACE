using System.Drawing;

namespace appComercio
{
    public interface IModernRoundButton
    {
        int BorderRadius { get; set; }
        Color HoverColor { get; set; }
        Color NormalColor { get; set; }
        Color TextColor { get; set; }
    }
}