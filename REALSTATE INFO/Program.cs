using RealState_Project;

namespace REALSTATE_INFO
{
    static class Program
    {        
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(AllForms.realstate_Info);
        }
    }
    public class AllForms
    {
        public static Realstate_info realstate_Info = new Realstate_info();
        public static Manager manager = new Manager();
        public static Employee employee = new Employee();
        public static Agent agent = new Agent();
        public static Departments departments = new Departments();
        public static PropertyForSale propertyForSale = new PropertyForSale();
        public static PropertyForRent propertyForRent = new PropertyForRent();
        public static Buyer buyer = new Buyer();
        public static Sales sales = new Sales();
        public static SalesForRent salesForRent = new SalesForRent();
        public static Projects projects = new Projects();
        public static PropertyWhichAreAvailableForSale propertyWhichAreAvailableForSale = new PropertyWhichAreAvailableForSale();
        public static EmployeeDetailsWithDepartment employeeDetailsWithDepartment = new EmployeeDetailsWithDepartment();
        public static AgentDetailsWithWorkingprocject agentDetailsWithWorkingprocject = new AgentDetailsWithWorkingprocject();
        public static AVALAIBLEAGENTS aVALAIBLEAGENTS = new AVALAIBLEAGENTS();
        public static PropertyWhichAreAvailableForRent propertyWhichAreAvailableForRent = new PropertyWhichAreAvailableForRent();
    }
}