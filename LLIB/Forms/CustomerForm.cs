using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LLIB.Data;
using LLIB.Models;

namespace LLIB.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly LibraryContext _context;
        public CustomerForm()
        {
            _context = new LibraryContext();

            InitializeComponent();
        }

        #region FillMethods
        private void FillTodayOrders()
        {
            DateTime now = DateTime.Now;
            var todayOrders = _context.Orders
                                     .Include("Customer")
                                     .Include("OwnerUser")
                                     .Where(t => !t.IsDone &&
                                                 t.Deadline.Year == now.Year &&
                                                 t.Deadline.Month == now.Month &&
                                                 t.Deadline.Day == now.Day)
                                     .ToList();
            foreach (var item in todayOrders)
            {

                DgvSearchResult.Rows.Add(item.CustomerId,
                                       item.OwnerUser.Fullname,
                                       item.Customer.Name + " " + item.Customer.Surname,
                                       item.Customer.Phone,
                                       item.Deadline.ToString("HH:mm dd.MM.yyyy"));
            }
        }
            #endregion
        }
    }

