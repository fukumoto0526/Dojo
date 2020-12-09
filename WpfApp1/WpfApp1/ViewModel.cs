using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using System.Runtime.CompilerServices;

namespace WpfApp1
{
    class ViewModel : INotifyPropertyChanged
    {
        public Model m_model;

        public ViewModel()
        {
            m_model = new Model();
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
