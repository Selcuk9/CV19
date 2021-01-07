using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CV19.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName">Имя методо откуда вызывается данная функция</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Задача этого метода чтобы обновлят колцевые свойства 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="feild">Сюда идет ссылка на поле свойства</param>
        /// <param name="value">новое значение, который хотим установить</param>
        /// <param name="propertyName">Этот параметр самостоятельно определит, какой метод вызвал данную процедуру</param>
        /// <returns></returns>
        protected virtual bool Set<T>(ref T feild,T value, [CallerMemberName] string propertyName)
        {
            if (Equals(feild, value)) return false;
            feild = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
