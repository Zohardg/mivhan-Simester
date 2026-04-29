using System;
using System.Collections.Generic;
using System.Text;

namespace בוחן_אמצע_סימסטר
{
    public interface IBankBranch
    {
        void AddAccount(CheckingAccount account);
        void PrintAccounts();
    }
}
