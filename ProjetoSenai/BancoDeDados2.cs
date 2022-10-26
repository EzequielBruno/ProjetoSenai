using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSenai
{
    public partial class BancoDeDados2 : Component
    {
        public BancoDeDados2()
        {
            InitializeComponent();
        }

        public BancoDeDados2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
