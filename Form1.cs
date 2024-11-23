using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppTablaMultiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            this.richTextBoxResultados.Text="";
            this.muestraTabla();
        }

        private void muestraTabla()
        {
            int num;
            string tabla="";
            num = Convert.ToInt32(this.txtNum.Text);

            for (int i = 1; i <= 10; i++){
                tabla = tabla + num + " x " + i + " = " + (num * i) + "\n";
            }
            this.richTextBoxResultados.AppendText(tabla);
        }
    }
}
