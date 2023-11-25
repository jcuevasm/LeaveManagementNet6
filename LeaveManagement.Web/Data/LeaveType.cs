namespace LeaveManagement.Web.Data
{
    public class LeaveType : BaseEntity
    {
        public string name { get; set; }
        public int DefaultDays { get; set; }
    }
}
