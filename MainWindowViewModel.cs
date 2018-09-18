using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDialogIssue41
{
    public class MainWindowViewModel : BindableBase
    {
        private string _text;

        public MainWindowViewModel()
        {
            Text = "MAIN WINDOW";
        }

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}
