using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace WpfApp1
{
    class ViewModel
    {
        public Model _model;

        public ViewModel()
        {
            _model = new Model();
        }

        public string Name
        {
            get { return "hogege"; }

        }
    }
}
