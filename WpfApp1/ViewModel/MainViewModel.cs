using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    internal class MainViewModel : ViewModelBase, IDataErrorInfo
    {
        private string fileText;
        private string findText;

        private ICommand openFileCommand;
        private ICommand saveFileCommand;
        private ICommand exitCommand;
        private ICommand findCommand;
        private ICommand cancelFindCommand;
        private ICommand openFindCommand;
        
        private string text;

       

        public string Text { get => text; set => text = value; }
        public string FileText { get => fileText; set => fileText = value; }
        public string FindText { get => findText; set => findText = value; }

        string simpleText = "#include <iostream>\n#include <cstdlib>\n\nusing namespace std;\n\nint main()\n{\n\tfor ( unsigned int = 0; i < n; i++)\n\t{\n\t\tcout<<\"Lorem Ipsum dolor sit amet\"<<endl;\n\t}\n\n\treturn 0;\n}";


        //public string FileText
        //{
        //    get { return this.fileText; }
        //    set
        //    {
        //        if (!string.Equals(this.fileText, value))
        //        {
        //            this.fileText = value;
        //            this.RaisePropertyChanged();
        //        }
        //    }
        //}


        public MainViewModel()
        {
            this.text = "";
            this.FileText = simpleText;
        }


        public ICommand OpenFileCommand
        {
            get
            {
                return openFileCommand ?? (openFileCommand = new RelayCommand(() => openFile()));
            }
        }

        public ICommand SaveFileCommand
        {
            get
            {
                return saveFileCommand ?? (saveFileCommand = new RelayCommand(() => saveFile()));
            }
        }

        public ICommand ExitCommand
        {
            get
            {
                return exitCommand ?? (exitCommand = new RelayCommand(() => exit()));
            }
        }

        public ICommand FindCommand
        {
            get
            {
                return findCommand ?? (findCommand = new RelayCommand(() => find()));
            }
        }

        public ICommand CancelFindCommand
        {
            get
            {
                return cancelFindCommand ?? (cancelFindCommand = new RelayCommand(() => cancelFindWindow()));
            }
        }

        public ICommand OpenFindCommand
        {
            get
            {
                return openFindCommand ?? (openFindCommand = new RelayCommand(() => openFindWindow()));
            }
        }

        public void openFile()
        {
            Console.WriteLine(text);
        }

        public void saveFile()
        {
            text = FileText;
        }

        public void exit()
        {
            System.Windows.Application.Current.Shutdown();
        }

        public void find()
        {
            string textToFind = findText;
            // i dalej wywołać szukanie frazy
        }

        public void cancelFindWindow()
        {

        }

        public void openFindWindow()
        {
            //FindWindow.Visibility = Visibility.Hidden;
        }









        public string this[string columnName]
        {
            get     
            {
                string result = string.Empty;
                return result;
            }
        }

        public string Error
        {
            get
            {
                return null;
            }
        }

    }
}
