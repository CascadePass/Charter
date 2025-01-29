using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charter
{
    /// <summary>
    /// Base class for objects implementing <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    public class Observable
    {
        /// <summary>
        /// Event raised when the value of a property changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises the <see cref="PropertyChanged"/> event.
        /// </summary>
        /// <param name="propertyName">The name of the property whose
        /// value has changed.</param>
        internal virtual void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class ViewModel : Observable
    {
        internal void SetPropertyValue<T>(ref T field, T value, string propertyName)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                OnPropertyChanged(propertyName);
            }
        }

        internal void SetPropertyValue<T>(ref T field, T value, string[] propertyNames)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;

                foreach (string propertyName in propertyNames)
                {
                    OnPropertyChanged(propertyName);
                }
            }
        }
    }
}
