using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniprojetinho
{
    public partial class MDITelas : Form
    {
        public static string stringConexao = "" +
        "Data Source=localhost;" +
        "Initial Catalog=T14_Estoque;" +
        "User ID=sa;" +
        "Password=123456";

        public static string idUsuario;
        public static string nomeUsuario;
        public static string loginUsuario;


        private int childFormNumber = 0;

        public MDITelas()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDITelas_Load(object sender, EventArgs e)
        {
          
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
  
        }
        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmusuario frm = new frmusuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto frm = new frmProduto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void localEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalEstoque frm = new frmLocalEstoque();
            frm.MdiParent = this;
            frm.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfuncio frm = new frmfuncio();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmforn frm = new frmforn();
            frm.MdiParent = this;
            frm.Show();
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmovi frm = new frmmovi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void itemEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemEstoque frm = new frmItemEstoque();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOS frm = new frmOS();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
