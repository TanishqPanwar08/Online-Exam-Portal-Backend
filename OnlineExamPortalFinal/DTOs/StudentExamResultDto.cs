﻿namespace OnlineExamPortalFinal.DTOs
{
    public class StudentExamResultDto
    {
        public int SrNo { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public string PerformanceMetrics { get; set; }
        public string Status { get; set; } = "Fail";  // "Pass" or "Fail"
    }
}