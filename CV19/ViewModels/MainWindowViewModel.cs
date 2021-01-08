using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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





    }
}
