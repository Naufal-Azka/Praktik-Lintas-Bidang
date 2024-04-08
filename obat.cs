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
    public partial class obat : UserControl
    {
        public obat()
        {
            InitializeComponent();

            paracetamolLabel.Text = "Obat untuk meredakan Sakit kepala dan demam.\r\rPenggunaan :\n500-1000 mg per dosis, maksimal 4000 mg per hari";
            ibuprofenLabel.Text = "Obat untuk meredakan Sakit kepala dan demam.\r\rPenggunaan :\n200-400 mg per dosis, maksimal 1200 mg per hari";

            dextromethorphanLabel.Text = "Obat untuk meredakan Batuk.\r\rPenggunaan :\n10-20 mg per dosis, maksimal 120 mg per hari";
            guaifenesinLabel.Text = "Obat untuk meredakan Batuk.\r\rPenggunaan :\n200-400 mg per dosis, maksimal 1200 mg per hari";

            diphenhydramineLabel.Text = "Obat untuk meredakan alergi.\r\rPenggunaan :\n25-50 mg per dosis, maksimal 300 mg per hari";
            loratadineLabel.Text = "Obat untuk meredakan alergi.\r\rPenggunaan :\n10 mg per hari";

            loperamideLabel.Text = "Obat untuk diare.\r\rPenggunaan :\n4 mg per dosis awal, kemudian 2 mg per dosis setelah setiap buang air besar (BAB), maksimal 16 mg per hari";
            smectaLabel.Text = "Obat untuk diare.\r\rPenggunaan :\n3 sachet per hari";
            
            lactuloseLabel.Text = "Obat untuk sembelit.\r\rPenggunaan :\n10-30 ml per hari";
            bisacodylLabel.Text = "Obat untuk sembelit.\r\rPenggunaan :\n5-10 mg per dosis";
            
            omeprazoleLabel.Text = "Obat untuk meredakan maag.\r\rPenggunaan :\n20 mg per hari";
            lansoprazoleLabel.Text = "Obat untuk meredakan maag.\r\rPenggunaan :\n30 mg per hari";
            
            amoxicillinLabel.Text = "Obat untuk infeksi bakteri.\r\rPenggunaan :\n500-1000 mg per dosis, maksimal 3000 mg per hari";
            
            FluconazoleLabel.Text = "Obat untuk infeksi jamur.\r\rPenggunaan :\n150-400 mg per hari";
            itraconazoleLabel.Text = "Obat untuk infeksi jamur.\r\rPenggunaan :\n100-200 mg per hari";
            
            amlodipineLabel.Text = "Obat untuk hipertensi.\r\rPenggunaan :\n5-10 mg per hari";
            lisinoprilLabel.Text = "Obat untuk hipertensi.\r\rPenggunaan :\n10-40 mg per hari";
            
            metforminLabel.Text = "Obat untuk diabetes.\r\rPenggunaan :\n500-1000 mg per dosis, maksimal 2000 mg per hari";
            glibenclamideLabel.Text = "Obat untuk diabetes.\r\rPenggunaan :\n2,5-5 mg per hari";
            
            atorvastatinLabel.Text = "Obat untuk kolesterol tinggi.\r\rPenggunaan :\n10-40 mg per hari";
            simvastatinLabel.Text = "Obat untuk kolesterol tinggi.\r\rPenggunaan :\n10-40 mg per hari";
        }
    }
}
