namespace AccountManagement
{
    public interface IBankBranch
    {
        void AddAccount(CheckingAccount account);
        void PrintAccounts();
    }
}
