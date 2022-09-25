﻿namespace Tutoring_Platform.Models
{
    public class LookForTutorParam
    {
        public string? CourseName { get; set; }
        public int[]? Days { get; set; }
    }
    public class SearchTutorsReturn
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? School { get; set; }
        public string? Program { get; set; }
        public string? Status { get; set; }
        public string? Wage { get; set; }
    }
}
