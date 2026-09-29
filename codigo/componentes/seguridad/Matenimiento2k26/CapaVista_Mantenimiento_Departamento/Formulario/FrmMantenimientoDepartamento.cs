using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Mantenimiento_Departamento.Formulario
{
    public partial class FrmMantenimientoDepartamento : Form
    {
        public FrmMantenimientoDepartamento()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tbldepartamento", 77, 77);
        }
    }
}
