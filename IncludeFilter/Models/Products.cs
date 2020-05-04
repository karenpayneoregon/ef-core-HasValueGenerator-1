using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AsyncOperations
{
    public partial class Products : INotifyPropertyChanged
    {
        private string _productName;

        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int ProductId { get; set; }

        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged();
            }
        }

        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public DateTime? DiscontinuedDate { get; set; }

        public virtual Categories Category { get; set; }
        public virtual Suppliers Supplier { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}