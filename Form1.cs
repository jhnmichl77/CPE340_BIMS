using MaterialSkin;
using MaterialSkin.Controls;

namespace CPE340_BIMS
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green200, Primary.Green700, Primary.LightGreen100,  Accent.LightGreen200, TextShade.WHITE);
        }
    }
}
