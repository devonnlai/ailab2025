namespace HR.API.Models.Departments
{
    public class DepartmentListRequest
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? SearchTerm { get; set; }
        public bool IncludeSubDepartments { get; set; } = false;
    }
}
