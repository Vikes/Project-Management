using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace Project_Management
{
    public class SettingBinding : Binding
    {
        public SettingBinding()
        {
            Initialize();
        }

        public SettingBinding(string path)
            : base(path)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.Source = Properties.Settings.Default;
            this.Mode = BindingMode.TwoWay;
        }
    }
}

