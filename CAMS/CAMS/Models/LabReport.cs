﻿using System;
using System.Collections.Generic;

namespace CAMS.Models
{
    public class LabReport
    {
        private TimeSpan labTotalActiveTime;
        private double labTotalHours;

        public Lab Lab;
        public List<ComputerReport> ComputersReport;
        public double AverageUsage
        {
            get
            {
                if (labTotalHours == 0) return 0;

                return (labTotalActiveTime.TotalHours / labTotalHours) * 100;
            }
        }
        public double ScheduleAverageUsage
        {
            get
            {
                return 0;
            }
        }

        

        public LabReport(Lab lab)
        {
            Lab = lab;
            ComputersReport = new List<ComputerReport>();
            labTotalActiveTime = TimeSpan.Zero;
        }

        public void AddToLabTotalActivityTime(TimeSpan time)
        {
            labTotalActiveTime = labTotalActiveTime.Add(time);
        }
        public void AddToLabTotalHours(double hours)
        {
            labTotalHours += hours;
        }


    }
}