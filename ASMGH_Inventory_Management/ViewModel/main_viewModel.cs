using ASMGH_MyAttendance.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ASMGH_Inventory_Management.ViewModel
{
    class main_viewModel:ViewModelBase
    {




        #region COMMAND REGION

        public ICommand CloseWindow_cmd
        {
            get
            {
                return new ActionCommand(p => CloseWindow((Window)p, 0));
            }
        }

        private async void CloseWindow(Window win, int mil_delay)
        {
            if(win !=null)
            {
                await Task.Delay(mil_delay);
                win.Close();
            }
        }

        #endregion

    }
}