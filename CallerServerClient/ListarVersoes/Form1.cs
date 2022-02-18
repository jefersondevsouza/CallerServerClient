using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListarVersoes
{
    public partial class Form1 : Form
    {
        string appName = "Cliente";
        string servidorName = "Servidor";
        string clientExeAppName = "Olimpo.exe";
        string servidorExeAppName = "Servidor de Aplicacao Olimpo.exe";
        string pasta = Application.StartupPath; //o caminho onde vai iniciar a leitura procurando pelos aplicativos. Inicialmente esse aplicativo deve ficar na pasta raiz

        public Form1()
        {
            InitializeComponent();
            //pasta = @"C:\workspace\Dlls";
            this.ListarVersoes();
        }

        private void ListarVersoes()
        {
            DirectoryInfo d = new DirectoryInfo(pasta);
            int i =1;
            foreach (var directory in d.GetDirectories())
            {
                Button botaoOlimpo = this.PreparaBotao(i);
                botaoOlimpo.Tag = Path.Combine(directory.FullName, clientExeAppName);
                botaoOlimpo.Click += botao_Click;
                i++;
                Button botaoOlimpoWithServer = this.PreparaBotao(i);
                botaoOlimpoWithServer.Tag = Path.Combine(directory.FullName, servidorExeAppName);
                botaoOlimpoWithServer.Click += botao_Click;
                i++;

                botaoOlimpo.Text = appName + " - " + directory.Name;
                botaoOlimpoWithServer.Text = servidorName + " - " + directory.Name;

                this.flowPanelOlimpo.Controls.Add(botaoOlimpo);
                this.flowPanelOlimpoWithServer.Controls.Add(botaoOlimpoWithServer);
            }
        }

        void botao_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Process.Start(b.Tag.ToString());
        }

        private Button PreparaBotao(int count)
        {
            Button b = new Button();
            b.Dock = System.Windows.Forms.DockStyle.Top;
            b.Location = new System.Drawing.Point(3, 3);
            b.Name = "button" + count;
            b.Size = new System.Drawing.Size(186, 55);
            b.TabIndex = 0;
            b.Text = "button" + count;
            b.UseVisualStyleBackColor = true;

            return b;
        }


    }
}
