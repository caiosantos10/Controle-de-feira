using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFeira.ViewModel
{
    class Model : MainViewModel
    {
        private string _info;

        public string Info
        {
            get { return _info; }
            set { SetProperty(ref _info, value); }
        }
    }
}
