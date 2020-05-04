using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AsyncOperations
{
    public partial class Orders : INotifyPropertyChanged
    {
        private DateTime? _orderDate;
        private DateTime? _requiredDate;
        private DateTime? _shippedDate;
        private int? _shipVia;
        private decimal? _freight;
        private string _shipAddress;
        private string _shipCity;
        private string _shipRegion;
        private string _shipPostalCode;
        private string _shipCountry;

        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int OrderId { get; set; }
        public int? CustomerIdentifier { get; set; }
        public int? EmployeeId { get; set; }

        public DateTime? OrderDate
        {
            get => _orderDate;
            set
            {
                _orderDate = value;
                OnPropertyChanged();
            }
        }

        public DateTime? RequiredDate
        {
            get => _requiredDate;
            set
            {
                _requiredDate = value;
                OnPropertyChanged();
            }
        }

        public DateTime? ShippedDate
        {
            get => _shippedDate;
            set
            {
                _shippedDate = value;
                OnPropertyChanged();
            }
        }

        public int? ShipVia
        {
            get => _shipVia;
            set
            {
                _shipVia = value;
                OnPropertyChanged();
            }
        }

        public decimal? Freight
        {
            get => _freight;
            set
            {
                _freight = value;
                OnPropertyChanged();
            }
        }

        public string ShipAddress
        {
            get => _shipAddress;
            set
            {
                _shipAddress = value;
                OnPropertyChanged();
            }
        }

        public string ShipCity
        {
            get => _shipCity;
            set
            {
                _shipCity = value;
                OnPropertyChanged();
            }
        }

        public string ShipRegion
        {
            get => _shipRegion;
            set
            {
                _shipRegion = value;
                OnPropertyChanged();
            }
        }

        public string ShipPostalCode
        {
            get => _shipPostalCode;
            set
            {
                _shipPostalCode = value;
                OnPropertyChanged();
            }
        }

        public string ShipCountry
        {
            get => _shipCountry;
            set
            {
                _shipCountry = value;
                OnPropertyChanged();
            }
        }

        public virtual Customers CustomerIdentifierNavigation { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual Shippers ShipViaNavigation { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}