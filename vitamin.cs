using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLB
{
    public partial class vitamin : UserControl
    {
        public vitamin()
        {
            InitializeComponent();

            eyevitLabel.Text = "Eyevit merupakan suplemen untuk membantu memelihara kesehatan mata.\r\rKomposisi : Biliberry Dry Extract 80 mg, Lutein 250 mcg, Zeaxanthin 60 mcg, Retinol (Vitamin A) 1.600 IU, B-Karoten 10% 5 mg, Vitamin E 40 mg, Selenium 15 mcg, Zn Picolinat 5 mg.";

            ultravitLabel.Text = "Ultra Vitamin B Complex merupakan suplemen untuk memenuhi kebutuhan vitamin B.\r\rKomposisi : Vitamin B1 (5 mg), Vitamin B2 (1,4 mg), Niacin (16 mg), Vitamin B6 (5 mg), Folid Acid (200 mcg), Vitamin B12 (50 mcg), Biotin (25 mg), Pantothenic Acid (6 mg).";

            naturesplusLabel.Text = "Nature's Plus Vitamin D3 merupakan suplemen untuk memenuhi kebutuhan vitamin D3.\r\rKomposisi : Vitamin D3 1000 IU, Safflower oil, Gelatin, Glycerin, Sunflower oil, & Purified Water.";

            natur_eLabel.Text = "Natur-E Daily Nourishing merupakan suplemen untuk memenuhi kebutuhan vitamin E.\r\rKomposisi : Vitamin E 300 IU.";

            nowfoodsLabel.Text = "Now foods MK-7 Vitamin K-2 merupakan suplemen untuk memenuhi kebutuhan vitamin K.\r\rKomposisi : Vitamin K 100 mcg.";
        }
    }
}
