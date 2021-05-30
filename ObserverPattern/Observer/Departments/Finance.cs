using Observer.Subject;

namespace Observer.Departments
{
    public interface IFinance
    {
        void CalculateSalary();
    }
    public class Finance : IFinance, IResignationObserver
    {
        public Finance(IResignation resignation)
        {
            resignation.AddObserver(this);
        }
        public void CalculateSalary()
        {
            // calculates salary
        }

        public void Notify(string employeeId)
        {
            // whenever employee resigns notification will come here.
            // Finance department will take necessary action accordingly.

            UpdateXmlHelper xmlHelper = new UpdateXmlHelper();
            xmlHelper.UpdateNotificationDetail("Finance", employeeId);
        }
    }
}
