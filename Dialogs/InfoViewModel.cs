using MvvmDialogs;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDialogIssue41.Dialogs
{
    public class InfoViewModel : BindableBase, IModalDialogViewModel
    {
        private string _text;
        private bool? _dialogResult;

        public InfoViewModel()
        {
            Text = "INFO DIALOG";
            OkCommand = new DelegateCommand(OnOk);
        }

        private void OnOk()
        {
            DialogResult = true;
        }

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public DelegateCommand OkCommand { get; }

        public bool? DialogResult {
            get { return _dialogResult; }
            set { SetProperty(ref _dialogResult, value); }
        }
    }
}
