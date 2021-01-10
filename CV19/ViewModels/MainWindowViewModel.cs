using CV19.Infrastructures.Commands;
using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _title = "Анализ статиcтики CV19";

        #region Заголовок окна


        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _title;
            set => Set<string>(ref _title, value);
            #region
            //{
            //    //if (!Equals(_title, value)) return;
            //    //_title = value;
            //    //OnPropertyChanged("Title");
            //    Set<string>(ref _title,value);
            //}
            #endregion
        }
        #endregion




        private string _status = "Готов!";

        /// <summary>
        /// Статус программы
        /// </summary>
        public string Status
        {
            get => _status;
            set => Set<string>(ref _status, value);

        }

        #region Команды
        #region OnCloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();

        }   
        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Команды

            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted,CanCloseApplicationCommandExecute);

            #endregion
        }

    }
}
