using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SampleMVVM.Commands;

namespace oop10
{
    class AirTicketViewModel : INotifyPropertyChanged
    {
        public AirTicket airTicket;
        TicketsContext db;


        public AirTicketViewModel(AirTicket ticket)
        {
            this.airTicket = ticket;
        }

        public int Id
        {
            get
            {
                return airTicket.Id;
            }
            set
            {
                airTicket.Id = value;
                //OnPropertyChanged("Id");
            }
        }

       

        public string Date
        {
            get
            {
                return airTicket.Date;
            }
            set
            {
                airTicket.Date = value;
                //OnPropertyChanged("Date");
            }
        }

        public string Country
        {
            get
            {
                return airTicket.Country;
            }
            set
            {
                airTicket.Country = value;
                //OnPropertyChanged("Type");
            }
        }

        public int Count
        {
            get
            {
                return airTicket.Count;
            }
            set
            {
                airTicket.Count = value;
                OnPropertyChanged("Count");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #region Commands

        #region Купить

        private DelegateCommand getItemCommand;

        public ICommand GetItemCommand
        {
            get
            {
                if (getItemCommand == null)
                {
                    getItemCommand = new DelegateCommand(GetItem);
                }
                return getItemCommand;
            }
        }

        private void GetItem()
        {
            Count++;
            db = new TicketsContext();
            db.AirTickets.Load();
            AirTicket ticket = new AirTicket();
            ticket = db.AirTickets.Find(Id);
            ticket.Count = Count;
            db.SaveChanges();
            db.Dispose();
        }

        #endregion

        #region Возврат

        private DelegateCommand giveItemCommand;

        public ICommand GiveItemCommand
        {
            get
            {
                if (giveItemCommand == null)
                {
                    giveItemCommand = new DelegateCommand(GiveItem, CanGiveItem);
                }
                return giveItemCommand;
            }
        }

        private void GiveItem()
        {
            Count--;
            db = new TicketsContext();
            db.AirTickets.Load();
            AirTicket ticket = new AirTicket();
            ticket = db.AirTickets.Find(Id);
            ticket.Count = Count;
            db.SaveChanges();
            db.Dispose();
        }

        private bool CanGiveItem()
        {
            return Count > 0;
        }

        #endregion       
        #endregion
    }
}
