using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFeira.ViewModel
{
    class Model : MainViewModel
    {
        private string _id;

        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _info;

        public string Info
        {
            get { return _info; }
            set { SetProperty(ref _info, value); }
        }
    }
}
